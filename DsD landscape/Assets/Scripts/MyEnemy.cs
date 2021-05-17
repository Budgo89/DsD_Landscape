using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyEnemy : MobDie
{
    [SerializeField] private GameObject _PostProc;
    public float _vignetteValue = 0;
    public void Vignettes(float _vignetteValue)
    {
        _PostProc.GetComponent<PostProcessContr>()._vignetteValue = _vignetteValue;
        StartCoroutine("VignetteTimeCor");
    }
    private IEnumerator VignetteTimeCor()
    {
        yield return new WaitForSeconds(1);
        VignetteTime();
    }

    private void VignetteTime()
    {
        _PostProc.GetComponent<PostProcessContr>()._vignetteValue = 0f;
    }
}
