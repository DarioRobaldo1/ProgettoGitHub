using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

[RequireComponent(typeof(Damageable))]
public class BouncerOnDamage : MonoBehaviour, IDamageListener
{
    [SerializeField] private float BouncePower = 20.0f;
    public void OnDeath(GameObject killer)
    {
        if (killer.TryGetComponent(out Rigidbody rb))
        {
            rb.AddForce(-killer.transform.forward * BouncePower, ForceMode.Impulse);
        }
    }

    public void OnHurt(int damageTaken, int health, int MaxHealth, GameObject attacker)
    {
        if (attacker.TryGetComponent(out Rigidbody rb))
        {
            rb.AddForce(-attacker.transform.forward * BouncePower, ForceMode.Impulse);
        }
    }
}
