using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodyTriggeredAttacker : MonoBehaviour
{
    [SerializeField] private GameObject AttackerRoot;
    [SerializeField] private int AttackPower = 1;
    private void Start()
    {
        if (AttackerRoot == default(GameObject))
        {
            AttackerRoot = gameObject;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Damageable d))
        {
            d.TakeDamage(AttackPower, AttackerRoot);
        }
    }
    private void OnTriggerEnter(UnityEngine.Collider collision)
    {
        if (collision.gameObject.TryGetComponent(out Damageable d))
        {
            d.TakeDamage(AttackPower, AttackerRoot);
        }
    }
}
