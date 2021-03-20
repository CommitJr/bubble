Shader "BubbleR/StandardBubble"
{
    Properties
    {
		[Header(Base)]
        _MainColor ("Color", Color) = (1,1,1,0.2)
		_Glossiness("Smoothness", Range(0,1)) = 1.0
		_Metal("Metallic", Range(0,1)) = 1.0
		
		[Header(Bouncing)]
		_BounceAmplitude("Bounce Amplitude", Range(0,1)) = 0.2
		_BounceFrequency("Bounce Frequency Multiplier", Range(0, 5)) = 1



		[Header(Color Shifting)]
		_ColorShiftPeak("Color Shifting Offset (RGB)", Vector) = (0.3, 0.5, 0.8)
		_ColorShiftBand("Color Shifting Bands (RGB)", Vector) = (0.3, 0.2, 0.3)
		_ColorShifting("Color Shift Multiplier", Range(0,1)) = 1.0

		_ColorShiftNoise("Color Shift Noise", Vector) = (0.1, 1, 1, 0) // (multiplier, scale, speed, unused)

		[Enum(BubbleR.BlendMode)]
		_ColorShiftMode("Shift mode", Float) = 0

		[Toggle(SPATIAL_NOISE)] _SpatialNoise("Enable Spatial noise", Float) = 0
	}

	CustomEditor "BubbleShaderEditor"
	
	SubShader
	{
		Tags { "Queue" = "Transparent" }
		LOD 200
		
		CGINCLUDE
		#pragma multi_compile __ SPATIAL_NOISE
		#include "BubbleR.cginc"
		

		ENDCG

		// Semitransparent shadows pass
		Pass
		{
			Tags{ "LightMode" = "ShadowCaster" }

			CGPROGRAM

			#include "UnityCG.cginc"
			#include "UnityStandardShadow.cginc"
			#pragma multi_compile_shadowcaster
			#pragma vertex vert
			#pragma fragment frag


			sampler3D _DitherMaskLOD;
			
			struct v2f_shadow
			{
				UNITY_VPOS_TYPE screenPos : VPOS;
			};

			void vert(inout appdata_bubble v)
			{
				TransformVertex(v);

				v.vertex = UnityObjectToClipPos(v.vertex);
			}

			fixed4 frag(v2f_shadow i) : COLOR
			{
				float s = tex3D(_DitherMaskLOD, float3(i.screenPos.xy * 0.25, saturate(_MainColor.a*15/16))).a;
				clip(s - .1);
				return s;
			}
		ENDCG
	}
        
		CGPROGRAM
       
        #pragma surface surf Standard vertex:vert alpha:fade noshadow

		void vert(inout appdata_bubble v, out Input data)
		{
			UNITY_INITIALIZE_OUTPUT(Input, data);


			float bub = TransformVertex(v);
			data.color = v.color;
		}

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
			o.Albedo = _MainColor.rgb * IN.color.rgb;

			float3 sCol = CalculateShiftColor(IN);

			// Might probably need to get rid of if statements
			if (_ColorShiftMode == 0) // ADD
			{
				sCol = lerp(0, sCol, _ColorShifting);
				o.Albedo = o.Albedo + sCol;
			}
			else if (_ColorShiftMode == 1) // MUL
			{
				sCol = lerp(1, sCol, _ColorShifting);
				o.Albedo = o.Albedo * sCol;
			}
			else if (_ColorShiftMode == 2) // SUB
			{
				sCol = lerp(0, sCol, _ColorShifting);
				o.Albedo = o.Albedo - sCol;
			}


			o.Metallic = _Metal;
			o.Smoothness = _Glossiness;
			o.Alpha = _MainColor.a * IN.color.a;
        }
        ENDCG
    }

    FallBack "Standard"
}
