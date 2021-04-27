using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGUI_Scen2 : MonoBehaviour
{
    [SerializeField] private Renderer _goRenderer;
    private float _redColorValue = 0;
    private float _greenColorValue = 0;
    private float _blueColorValue = 0;
    private float _rgbAValue = 0;

    public void Update()
    {
        if (_goRenderer != null)
            _goRenderer.material.color = new Color(_redColorValue/255f, _greenColorValue/255f, _blueColorValue/255f, _rgbAValue/255f);
    }

    public void OnGUI()
    {
    GUILayout.BeginArea(new Rect(Screen.width*0.3f, Screen.height*0.6f,Screen.width*0.3f,Screen.height*0.3f));
    GUILayout.BeginHorizontal();
    GUILayout.Label("RED      Channel");
    _redColorValue = GUILayout.HorizontalSlider(_redColorValue, 0, 255); 
    GUILayout.EndHorizontal();

    GUILayout.BeginHorizontal();
    GUILayout.Label("GREEN Channel");
    _greenColorValue = GUILayout.HorizontalSlider(_greenColorValue, 0, 255);
    GUILayout.EndHorizontal();
    
    GUILayout.BeginHorizontal();
    GUILayout.Label("BLUE     Channel");
    _blueColorValue = GUILayout.HorizontalSlider(_blueColorValue, 0, 255);
    GUILayout.EndHorizontal();
    
    GUILayout.BeginHorizontal();
    GUILayout.Label("rgbA");
    _rgbAValue = GUILayout.HorizontalSlider(_rgbAValue, 0, 255);
    GUILayout.EndHorizontal();
    GUILayout.EndArea();
    }
}
