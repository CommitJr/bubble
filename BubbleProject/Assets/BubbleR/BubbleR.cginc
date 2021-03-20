#ifndef BUBBLER_INCLUDED
#define BUBBLER_INCLUDED

#include "UnityInstancing.cginc"

half _BounceAmplitude, _BounceFrequency;
fixed4 _MainColor;

UNITY_INSTANCING_BUFFER_START(Props)
UNITY_INSTANCING_BUFFER_END(Props)

inline float mod289(float x) { return x - floor(x * (1.0 / 289.0)) * 289.0; }
inline float4 mod289(float4 x) { return x - floor(x * (1.0 / 289.0)) * 289.0; }
inline float4 perm(float4 x) { return mod289(((x * 34.0) + 1.0) * x); }

float GetNoise(float3 p) {
	float3 a = floor(p);
	float3 d = p - a;
	d = d * d * (3.0 - 2.0 * d);

	float4 b = a.xxyy + float4(0.0, 1.0, 0.0, 1.0);
	float4 k1 = perm(b.xyxy);
	float4 k2 = perm(k1.xyxy + b.zzww);

	float4 c = k2 + a.zzzz;
	float4 k3 = perm(c);
	float4 k4 = perm(c + 1.0);

	float4 o1 = frac(k3 * (1.0 / 41.0));
	float4 o2 = frac(k4 * (1.0 / 41.0));

	float4 o3 = o2 * d.z + o1 * (1.0 - d.z);
	float2 o4 = o3.yw * d.x + o3.xz * (1.0 - d.x);

	return o4.y * d.y + o4.x * (1.0 - d.y);
}
struct appdata_bubble
{
	float4 vertex : POSITION;
	float3 normal : NORMAL;
	fixed4 color : COLOR;
	float4 texcoord : TEXCOORD0;
	float4 texcoord1 : TEXCOORD1;
	float4 texcoord2 : TEXCOORD2;
	UNITY_VERTEX_INPUT_INSTANCE_ID
};

inline float TimeFunction(float timeScale, float offset)
{
	float t = offset + _Time.y * timeScale;

	// Add 3 sine waves to give a bit more "randomness" to the bubble
	float s = sin(t * 6) + sin(t * 2.72) + sin(t * 1.541);
	return s / 3.0;
}

float TransformVertex(inout appdata_bubble v)
{
	UNITY_SETUP_INSTANCE_ID(v)
		float offset = 0;

#ifdef UNITY_INSTANCING_ENABLED
	// If instancing is used, then we use the intance id to introduce a phase shift in the timing function.
	offset = unity_InstanceID * 0.631;

#endif

	float vMul = TimeFunction(_BounceFrequency, offset) * _BounceAmplitude * (1 - v.texcoord.z);
	float hMul = -vMul;



	v.vertex.y += v.normal.y * vMul * .1;
	v.vertex.xz += v.normal.xz * hMul * .1;

	return vMul;
}

inline float Center(float val, float center, float range)
{
	return 1 - saturate(pow(abs(val - center), 2) / (range * .5));
}

struct Input
{
	float2 uv_MainTexture;
	float3 viewDir;
	float3 worldNormal;
	float3 worldPos;
	float4 color;
};

inline float NoiseFromNormal(float3 norm, float scale, float speed)
{
	float t = _Time.y * speed;
	float val = sin(t + (.17 + norm.x * 3.17 * scale));
	val += sin(t + (.11 + norm.y * 2.57 * scale));
	val += sin(t + norm.z * 3.7 * scale);
	val += sin(t + norm.x * .45 + norm.y * .67 + norm.z * 1.46);
	return val;
}


half _Metal;


half _Glossiness;
half _ColorShifting;
half3 _ColorShiftPeak;
half3 _ColorShiftBand;
half3 _ColorShiftNoise;
float _ColorShiftMode;


float3 CalculateShiftColor(Input IN)
{
	float3 basePos = 0;

#if SPATIAL_NOISE
	basePos = IN.worldPos * _ColorShiftNoise.y;
#endif

	float3 normal = IN.worldNormal.xyz;

	float3 noiseVector = sin(0.15 + basePos * float3(.231, .15, .16)) + (sin(basePos * float3(.31, .5, .9) + normal * 2.1) + sin(basePos * .04 + normal));

	float angle = saturate(1 - abs(dot(IN.viewDir, IN.worldNormal)));

	float colorShift = angle;

	float shiftNoise = GetNoise(basePos);

	float angularShiftNoise = (NoiseFromNormal(noiseVector, _ColorShiftNoise.y, _ColorShiftNoise.z));

	colorShift += (angularShiftNoise + shiftNoise) * _ColorShiftNoise.x;

	_ColorShiftPeak = saturate(_ColorShiftPeak);
	_ColorShiftBand = max(0, _ColorShiftBand);

	float3 sCol = float3(Center(colorShift, _ColorShiftPeak.x * _ColorShifting, _ColorShiftBand.x),
		Center(colorShift, _ColorShiftPeak.y  * _ColorShifting, _ColorShiftBand.y),
		Center(colorShift, _ColorShiftPeak.z  * _ColorShifting, _ColorShiftBand.z));

	return sCol;
}


#endif