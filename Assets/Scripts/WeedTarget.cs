using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class WeedTarget : MonoBehaviour
{
    private RoundManager rm;
    private void OnEnable()
    {
        rm = FindObjectOfType<RoundManager>();
        rm.OnWeedSpawned();
    }

    private void OnDisable()
    {
        rm.OnWeedDestroyed();
    }
}
