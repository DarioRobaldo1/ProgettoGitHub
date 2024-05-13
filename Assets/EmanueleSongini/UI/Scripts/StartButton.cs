using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartButton : MonoBehaviour
{

    public Button startButton;





    void Awake()
    {
        startButton = GetComponent<Button>();

        startButton.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        SceneManager.LoadScene("Livello1");
        
    
}

}
