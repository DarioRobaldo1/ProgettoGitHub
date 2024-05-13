using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] private readonly int MaxHealth = 1;
    private int CurrentHealth;
    private List<IDamageListener> damageListeners = new();
    private bool hasDamageListener;
    private void Start()
    {
        CurrentHealth = MaxHealth;
        GetComponents(damageListeners);
    }
    public void TakeDamage(int damage, GameObject attacker)
    {
        CurrentHealth -= damage;
        if (CurrentHealth < 0) { CurrentHealth = 0; }
        //Notify listener of taking damage
        damageListeners.ForEach((IDamageListener dl) => dl.OnHurt(damage, CurrentHealth, MaxHealth, attacker));

        if (CurrentHealth <= 0)
        {
            // Notify listener that they will die in this moment
            damageListeners.ForEach((IDamageListener dl) => dl.OnDeath(attacker));
            Destroy(this);
        }
    }
}

