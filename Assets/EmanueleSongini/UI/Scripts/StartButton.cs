using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{

    public Button startButton;





    void Awake()
    {
        startButton = GetComponent<Button>();

        startButton.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        SceneManager.LoadScene("Livello1");
        
    
}

}
