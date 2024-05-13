using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    public Button exitButton;



    public void Awake()
    {
        exitButton = GetComponent<Button>();

        exitButton.onClick.AddListener(OnClick);
    }
    public void OnClick()
    {
        Application.Quit();
        
    }
   


}
