using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Health : NetworkBehaviour
{
    [field: SerializeField] public int MaxHealth { get; private set; } = 100;

    public NetworkVariable<int> CurrentHealth = new NetworkVariable<int>();

    private bool _isDead;
    public Action<Health> onDie;

    public override void OnNetworkSpawn()
    {
        if (!IsServer) {  return; } 
        CurrentHealth.Value = MaxHealth;
    }
    public void TakeDamage(int damageValue)
    {
        ModifyHealth(-damageValue);
    }
    public void RestoreHealth(int healthValue)
    {
         ModifyHealth(healthValue);
    }
    private void ModifyHealth(int value)
    {
        if (_isDead) { return; }

        int newHealth = CurrentHealth.Value + value;
        CurrentHealth.Value = Mathf.Clamp(newHealth, 0, MaxHealth);

        if (CurrentHealth.Value == 0)
        {
            onDie?.Invoke(this);
            _isDead = true;
        }
    }
}
