using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonVisibilityManager : MonoBehaviour
{
    public Button buttonToShow; // Кнопка, которую нужно сделать видимой

    private void Start()
    {
        // Скрываем кнопку при старте
        buttonToShow.gameObject.SetActive(false);
    }

    public void ShowButton()
    {
        // Делаем кнопку видимой при вызове этой функции
        buttonToShow.gameObject.SetActive(true);
    }
}
