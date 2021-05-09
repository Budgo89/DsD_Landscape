using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OpenOnionDialogue : MonoBehaviour
{
    [SerializeField] private TMP_Text _hinr;
    public int i = 1;

    private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            if (i == 1)
            {
                _hinr.text = "Нажтите Е";
                gameObject.GetComponent<OnionDialogue>().enabled = true;
            }
            if (i == 2)
            {
                _hinr.text = "Нажтите Е";
                gameObject.GetComponent<ArrowDialogue>().enabled = true;
            }
            if (i == 3)
            {
                _hinr.text = "Нажтите Е";
                gameObject.GetComponent<KnightKillDialogue>().enabled = true;
            }
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (i == 1)
        {
            _hinr.text = " ";
            gameObject.GetComponent<OnionDialogue>().enabled = false;
        }
        if (i == 2)
        {
            _hinr.text = " ";
            gameObject.GetComponent<ArrowDialogue>().enabled = false;
        }
        if (i == 3)
        {
            _hinr.text = " ";
            gameObject.GetComponent<KnightKillDialogue>().enabled = false;
        }
    }
}
