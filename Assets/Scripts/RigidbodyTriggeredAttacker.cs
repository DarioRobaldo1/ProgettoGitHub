using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodyTriggeredAttacker : MonoBehaviour
{
    [SerializeField] private int AttackPower = 1;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Damageable d))
        {
            d.TakeDamage(AttackPower, gameObject);
        }
    }
    private void OnTriggerEnter(UnityEngine.Collider collision)
    {
        if (collision.gameObject.TryGetComponent(out Damageable d))
        {
            d.TakeDamage(AttackPower, gameObject);
        }
    }
}
