using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevertExit : MonoBehaviour
{
    public Button revertButton;
    public GameObject hideButton;
    public GameObject confirmButtons;




    public void Awake()
    {
        revertButton = GetComponent<Button>();

        revertButton.onClick.AddListener(OnClick);
    }
    public void OnClick()
    {
        hideButton.SetActive(true);
        confirmButtons.SetActive(false);

    }

}
