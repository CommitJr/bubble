using UnityEditor;
using UnityEngine;
using BubbleR;

public class BubbleShaderTexturedEditor : ShaderGUI
{

	static Color SLIDER_RED = new Color(.8f, .3f, .3f, 1f);
	static Color SLIDER_GREEN = new Color(.3f, .8f, .3f, 1f);
	static Color SLIDER_BLUE = new Color(.3f, .3f, .8f, 1f);


	public override void OnGUI(MaterialEditor materialEditor, MaterialProperty[] properties)
	{
		if (materialEditor.targets.Length>1)
		{
			EditorGUILayout.HelpBox("Multiple selection is not supported.", MessageType.Error);
			return;
		}
		GUILayout.Label("Base", EditorStyles.boldLabel);

		MaterialProperty mainTex = FindProperty("_MainTexture", properties);

		MaterialProperty mainColor = FindProperty("_MainColor", properties);
		MaterialProperty glossiness = FindProperty("_Glossiness", properties);
		MaterialProperty metallic = FindProperty("_Metal", properties);

		materialEditor.TexturePropertySingleLine(new GUIContent("Main Texture"), mainTex, mainColor);
		//materialEditor.ColorProperty(mainColor, "Base color");
		materialEditor.RangeProperty(glossiness, "Smoothness");
		materialEditor.RangeProperty(metallic, "Metallic");

		GUILayout.Space(10f);

		materialEditor.EnableInstancingField();
		materialEditor.RenderQueueField();

		GUILayout.Space(20f);

		GUILayout.Label("Animation", EditorStyles.boldLabel);
		MaterialProperty amplitude = FindProperty("_BounceAmplitude", properties);
		MaterialProperty frequency = FindProperty("_BounceFrequency", properties);
		
		materialEditor.RangeProperty(amplitude, "Bounce Amplitude");
		materialEditor.RangeProperty(frequency, "Bounce Frequency");


		GUILayout.Space(20f);

		GUILayout.Label("Color shifting", EditorStyles.boldLabel);

		MaterialProperty shiftMode = FindProperty("_ColorShiftMode", properties);

		BlendMode blendMode = (BlendMode)((int)shiftMode.floatValue);
		blendMode = (BlendMode)EditorGUILayout.EnumPopup("Shift Blend Mode", blendMode);

		shiftMode.floatValue = (float)blendMode;

		MaterialProperty shiftMul = FindProperty("_ColorShifting", properties);
		materialEditor.RangeProperty(shiftMul, "Shifting Intensity");

		EditorGUILayout.HelpBox("You can play with the shifting's color channels to achieve different effects.", MessageType.Info);
		MaterialProperty peaks = FindProperty("_ColorShiftPeak", properties);
		MaterialProperty range = FindProperty("_ColorShiftBand", properties);

		Vector3 p = peaks.vectorValue;
		Vector3 r = range.vectorValue;

		Vector3 min = p - (r / 2f);
		Vector3 max = p + (r / 2f);
		
		GUI.color = SLIDER_RED;
		EditorGUILayout.MinMaxSlider("Red Shifting", ref min.x, ref max.x, 0, 1);

		GUI.color = SLIDER_GREEN;
		EditorGUILayout.MinMaxSlider("Green Shifting", ref min.y, ref max.y, 0, 1);

		GUI.color = SLIDER_BLUE;
		EditorGUILayout.MinMaxSlider("Blue Shifting", ref min.z, ref max.z, 0, 1);

		GUI.color = Color.white;
		min = Vector3.Max(Vector3.zero, min);
		max = Vector3.Min(Vector3.one, max);

		p = (min + max) / 2f;
		r = (max - min);

		peaks.vectorValue = p;
		range.vectorValue = r;


		GUILayout.Space(10f);

		MaterialProperty spatialNoise = FindProperty("_SpatialNoise", properties);
		materialEditor.ShaderProperty(spatialNoise, new GUIContent("Enable spatial noise"));

		MaterialProperty shiftNoise = FindProperty("_ColorShiftNoise", properties);

		Vector3 noiseValues = shiftNoise.vectorValue;

		noiseValues.x = EditorGUILayout.Slider("Shift Noise Intensity", noiseValues.x, 0f, 1f);
		noiseValues.y = EditorGUILayout.Slider("Shift Noise Scale", noiseValues.y, 0f, 2f);
		noiseValues.z = EditorGUILayout.Slider("Shift Noise Speed", noiseValues.z, 0f, 10f);

		shiftNoise.vectorValue = noiseValues;

	}

}
