using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnerOnDestruction : MonoBehaviour
{
    [SerializeField] private GameObject toSpawn;
    private void OnDestroy()
    {
        Instantiate(toSpawn, transform.position, transform.rotation);
    }
}
