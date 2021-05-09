using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ArrowDialogue : MonoBehaviour
{
    [SerializeField] private GameObject _scroll;
    [SerializeField] private TMP_Text _dialogueIntroduction;
    [SerializeField] private Button _answer;
    [SerializeField] private TMP_Text _task;
    [SerializeField] private GameObject _player;
    [SerializeField] private TMP_Text _hinr;
    [SerializeField] private GameObject _knight;
    
    private int phrase = 0;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && gameObject.GetComponent<OpenOnionDialogue>().i == 2)
        {
            gameObject.GetComponent<OpenOnionDialogue>().i = 0;
            _player.GetComponent<FirstPersonController>().enabled = false;
            _player.GetComponent<BoomArrow>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _task.text = " ";
            _hinr.text = " ";
            _answer.gameObject.SetActive(true);
            _scroll.SetActive(true);
            _dialogueIntroduction.text = "Вижу ты подобрал лук. Теперь собственно сама просьба. Ты готов?";
            _answer.GetComponentInChildren<Text>().text = "Готов.";
            _answer.onClick.AddListener(DialogAnswer);
        }
    }
    private void DialogAnswer()
    {
        Dialog();
        phrase++;
    }

    private void Dialog()
    {
        if (phrase == 0)
        {
            _dialogueIntroduction.text = "Тут не далеко засел разбойник и не даёт мне работать. Сможешь справиться с ним?";
            _answer.GetComponentInChildren<Text>().text = "Это не проблема";
        }
        if (phrase == 1)
        {
            _dialogueIntroduction.text = " ";
            _answer.GetComponentInChildren<Text>().text = " ";
            _player.GetComponent<FirstPersonController>().enabled = true;
            _player.GetComponent<BoomArrow>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            _answer.gameObject.SetActive(false);
            _scroll.SetActive(false);
            _task.text = "Найдите и убейте разбойника";
            _knight.SetActive(true);
            gameObject.GetComponent<ArrowDialogue>().enabled = false;
        }
    }

}
