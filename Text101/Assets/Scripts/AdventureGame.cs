using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;                 // добавляем поле в которое можно вставить текст
    [SerializeField] State startingState;                // добавляем поле в которое можно вставить переменную State

    State state;                                         // создаем переменную state тип State


    // Start is called before the first frame update
    void Start()
    {
        state = startingState;                          // при страрте присваеваем нашей переменной значение стартовой переменной
        textComponent.text = state.GetStateStory();     // считываем текст из нашей переменной

    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
        ExitButton();
    }
    private void ExitButton()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    private void ManageState()
    {

        var nextStates = state.GetNextStates();         // отслеживаем текущий стайт
        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
        }

/*        if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    state = nextStates[0];
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    state = nextStates[1];
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    state = nextStates[2];
                }
        */
        textComponent.text = state.GetStateStory();
    }
}
