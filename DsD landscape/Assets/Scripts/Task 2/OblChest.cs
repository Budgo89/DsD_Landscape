using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OblChest : MonoBehaviour
{
    [SerializeField] private TMP_Text _hinr;
    [SerializeField] private GameObject _chest;
    private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            _hinr.text = "Нажмите Е";
            _chest.GetComponent<OpenChest>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _hinr.text = " ";
        _chest.GetComponent<OpenChest>().enabled = false;
    }
}
