using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class KnightKillDialogue : MonoBehaviour
{
    [SerializeField] private GameObject _scroll;
    [SerializeField] private TMP_Text _dialogueIntroduction;
    [SerializeField] private Button _answer;
    [SerializeField] private TMP_Text _task;
    [SerializeField] private GameObject _player;
    [SerializeField] private TMP_Text _hinr;
    
    private int phrase = 0;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && gameObject.GetComponent<OpenOnionDialogue>().i == 3)
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
            _dialogueIntroduction.text = "Благодарю тебя.";
            _answer.GetComponentInChildren<Text>().text = "Впервые вижу разбойника чародея.";
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
            _dialogueIntroduction.text = "Чародей говоришь? Тебе нужно идти в низ, в деревню. Найди там главу охраны и сообщи об этом.";
            _answer.GetComponentInChildren<Text>().text = "А как отсюда спустится?";
        }
        if (phrase == 1)
        {
            _dialogueIntroduction.text = "Иди дальше по тропе через озеро, и дальше увидешь спуск в небольшое ущелье. Иди по ущелью и попадёшь в деревню.";
            _answer.GetComponentInChildren<Text>().text = "Благодарю тебя.";
        }
        if (phrase == 2)
        {
            _dialogueIntroduction.text = " ";
            _answer.GetComponentInChildren<Text>().text = " ";
            _player.GetComponent<FirstPersonController>().enabled = true;
            _player.GetComponent<BoomArrow>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            _answer.gameObject.SetActive(false);
            _scroll.SetActive(false);
            _task.text = "Спуститесь в деревню";
            _hinr.text = "Контент в разработки, ожидайте одновления";
            gameObject.GetComponent<KnightKillDialogue>().enabled = false;
        }
    }
}
