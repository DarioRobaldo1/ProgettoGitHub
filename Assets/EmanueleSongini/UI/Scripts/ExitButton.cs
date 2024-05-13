using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{

    public Button exitButton;





    void Awake()
    {
        exitButton = GetComponent<Button>();

        exitButton.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        Application.Quit();

    }
}
