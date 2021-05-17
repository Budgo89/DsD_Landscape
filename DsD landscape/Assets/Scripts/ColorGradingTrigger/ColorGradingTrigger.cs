using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGradingTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _PostProc;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            _PostProc.GetComponent<PostProcessContr>()._colorGradingValue = 100;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _PostProc.GetComponent<PostProcessContr>()._colorGradingValue = 1;
    }
}
