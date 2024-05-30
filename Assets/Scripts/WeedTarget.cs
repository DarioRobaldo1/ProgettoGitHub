using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class WeedTarget : MonoBehaviour
{
    private RoundManager rm;
    private int realid;
    private int id
    {
        get
        {
            if (!idIsSet)
            {
                realid = _oriid++;
                idIsSet = true;
            }
            return realid;
        }
    }
    private bool idIsSet = false;
    private static int _oriid = 0;

    private void OnEnable()
    {
        rm = FindObjectOfType<RoundManager>();
        Debug.Log($"Weed {id} calls spawn for manager {rm.currentId}");
        rm.OnWeedSpawned();
    }

    private void OnDisable()
    {
        Debug.Log($"Weed {id} calls destroy for manager {rm.currentId}");
        rm.OnWeedDestroyed();
    }
}
