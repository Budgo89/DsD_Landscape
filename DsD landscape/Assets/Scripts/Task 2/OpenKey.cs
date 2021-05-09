using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OpenKey : MonoBehaviour
{
    [SerializeField] private GameObject _oblKey;
    [SerializeField] private GameObject _key;
    [SerializeField] private TMP_Text _task;
    [SerializeField] private GameObject _oblChest;
    [SerializeField] private TMP_Text _hinr;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _oblKey.SetActive(false);
            _key.SetActive(false);
            _oblChest.SetActive(true);
            _task.text = "Возьмите лук из сундука";
            _hinr.text = " ";
            gameObject.GetComponent<OpenKey>().enabled = false;
        }
    }
}
