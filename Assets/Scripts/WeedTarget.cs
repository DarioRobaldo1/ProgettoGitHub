using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class WeedTarget : MonoBehaviour
{
    private RoundManager[] rms;
    private void OnEnable()
    {
        rms = FindObjectsOfType<RoundManager>();
        foreach (RoundManager rm in rms)
        {
            rm.OnWeedSpawned();
        }
    }
    private void OnDisable()
    {
        foreach (RoundManager rm in rms)
        {
            rm.OnWeedDestroyed();
        }

    }
}
