using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGUI : MonoBehaviour
{
    [SerializeField] private GUISkin _skin;
    [SerializeField] private GameObject _player;
    private float _sliderValum = 0;

    public void Update()
    {
        _sliderValum = _player.gameObject.GetComponent<MyEnemy>()._health;
    }

    public void OnGUI()
    {
        GUI.HorizontalSlider(new Rect(Screen.width*0.1f,Screen.height*0.9f,Screen.width*0.2f,Screen.height*0.3f ), _sliderValum, 0,10);
    }
}
