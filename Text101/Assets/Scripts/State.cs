using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]                     // создаем новый тип переменной
public class State : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] string storyText; // создаем поле для ввода текста в нашу новую переменную
    [SerializeField] State[] nextStates;                  // объявляем массив с возможностью заносить в него элементы
    public string GetStateStory()
    {
        return storyText;                                 // возвращаем по завершению метода текст, который был записан в текстовое поле
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }

}
