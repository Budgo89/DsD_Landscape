using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class OnionDialogue : MonoBehaviour
{
    [SerializeField] private GameObject _scroll;
    [SerializeField] private TMP_Text _dialogueIntroduction;
    [SerializeField] private Button _answer;
    [SerializeField] private TMP_Text _task;
    [SerializeField] private GameObject _player;
    [SerializeField] private TMP_Text _hinr;
    [SerializeField] private GameObject _oblKey;
    private int phrase = 0;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && gameObject.GetComponent<OpenOnionDialogue>().i == 1)
        {
            gameObject.GetComponent<OpenOnionDialogue>().i = 0;
            _player.GetComponent<FirstPersonController>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _task.text = " ";
            _hinr.text = " ";
            _answer.gameObject.SetActive(true);
            _scroll.SetActive(true);
            _dialogueIntroduction.text = "Здрав будь путник.\n Кто ты? Как оказался в этой глуши? ";
            _answer.GetComponentInChildren<Text>().text = "Кажется я попал сюда из за гор.";
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
            _dialogueIntroduction.text = "Ого! К нам из за гор ещё не кто не приходил. Они считались не проходимыми.";
            _answer.GetComponentInChildren<Text>().text = "Куда я попал?";
        }

        if (phrase == 1)
        {
            _dialogueIntroduction.text = "Это предгорья страны Прувана.";
            _answer.GetComponentInChildren<Text>().text = "Прувана?";
        }

        if (phrase == 2)
        {
            _dialogueIntroduction.text = "Да, но я вряд ли смогу многое тебе рассказать. С виду ты вроде воин, но без оружия.";
            _answer.GetComponentInChildren<Text>().text = "Мой лук сломался в том странном туннели.";
        }
        if (phrase == 3)
        {
            _dialogueIntroduction.text = "У меня есть запасной лук. Если ты поможешь бедному лесорубу то я отдам его тебе.";
            _answer.GetComponentInChildren<Text>().text = "Думаю что оружие мне пригодится. Что нужно сделать?";
        }
        if (phrase == 4)
        {
            _dialogueIntroduction.text = "Лук лежит в сундуке в дальней комнате. А ключ от сундука на столе. Возьми лук и возвращайся ко мне.";
            _answer.GetComponentInChildren<Text>().text = "Скоро буду.";
        }
        if (phrase == 5)
        {
            _dialogueIntroduction.text = " ";
            _answer.GetComponentInChildren<Text>().text = " ";
            _player.GetComponent<FirstPersonController>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            _answer.gameObject.SetActive(false);
            _scroll.SetActive(false);
            _task.text = "Возьмите ключ со стола";
            _oblKey.SetActive(true);
            gameObject.GetComponent<OnionDialogue>().enabled = false;
        }
    }
}
