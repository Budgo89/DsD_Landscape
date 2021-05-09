using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class DialogueIntroduction : MonoBehaviour
{
    [SerializeField] private GameObject _scroll;
    [SerializeField] private TMP_Text _dialogueIntroduction;
    [SerializeField] private Button _proceed;
    [SerializeField] private TMP_Text _task;

    public void Start()
    {
        gameObject.GetComponent<FirstPersonController>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;
        _dialogueIntroduction.text = "Кажется я выбрался из этой ужасной пещеры. Но где это я? Не ужели я попал на противоположную сторону непроходимых гор? По эту сторону гор ни кто не бывал.\n \n Впереди я вижу тропинку. Ну что ж, делать нечего, нужно идти.";
    }

    private void Awake()
    {
        _proceed.onClick.AddListener(Proceed);
    }

    private void Proceed()
    {
        gameObject.GetComponent<FirstPersonController>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        _scroll.SetActive(false);
        _dialogueIntroduction.text = " ";
        _proceed.gameObject.SetActive(false);
        _task.text = "Идите по тропе";
    }
}
