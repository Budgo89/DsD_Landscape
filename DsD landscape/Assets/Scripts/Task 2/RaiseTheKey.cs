using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RaiseTheKey : MonoBehaviour
{
    [SerializeField] private TMP_Text _hinr;
    private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            _hinr.text = "А вот и ключ.\n Нажмите Е";
            gameObject.GetComponent<OpenKey>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _hinr.text = " ";
        gameObject.GetComponent<OpenKey>().enabled = false;
    }
}
