using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject UIConfirm;

    public void Awake()
    {

        UIConfirm.SetActive(false);
    }


       

}


