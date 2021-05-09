using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private TMP_Text _task;
    [SerializeField] private GameObject _arrow;
    [SerializeField] private GameObject _oblChest;
    [SerializeField] private TMP_Text _hinr;
    [SerializeField] private GameObject _brute;
    [SerializeField] private GameObject _player;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
     private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                _oblChest.SetActive(false);
                _task.text = "Вернитесь к лесорубу";
                _animator.SetBool("OpenChest", true);
                _arrow.SetActive(true);
                _brute.GetComponent<OpenOnionDialogue>().i = 2;
                _player.GetComponent<BoomArrow>().enabled = true;
                _hinr.text = "Теперь у вас есть лук, для стрельбы нажмите ЛКМ";
                StartCoroutine("HinrOffTaim");
            }
        }

     private void HinrOFF()
     {
         _hinr.text = " ";
         gameObject.SetActive(false);
     }

     private IEnumerator HinrOffTaim()
     {
         yield return new WaitForSeconds(6);
         HinrOFF();
     }
}
