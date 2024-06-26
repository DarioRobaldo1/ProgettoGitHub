using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{

    public Button exitButton;
    public GameObject hideButton;
    public GameObject confirmButtons;




    void Awake()
    {
        exitButton = GetComponent<Button>();

        exitButton.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        HideButtons();

    }

    public void HideButtons()
    {

        hideButton.SetActive(false);
        confirmButtons.SetActive(true);

    }

}
