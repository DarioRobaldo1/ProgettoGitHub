using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageListener
{
    public void OnHurt(int damageTaken, int health, int MaxHealth, GameObject attacker);
    public void OnDeath(GameObject killer);
}
