using System;
using System.Collections;
using System.Collections.Generic;
using Main_Scripts.EventSystem.SimpleEvents;
using PlayerStateMachineSystem;
using UnityEngine;

public class IsDeadCondition : Condition
{
    [SerializeField] private HealthSystem.HealthSystem healthSystem;

    private bool isDead;

    private void OnEnable()
    {
        healthSystem.DiedUnityEvent.AddListener(OnDeath);
    }

    private void OnDisable()
    {
        healthSystem.DiedUnityEvent.RemoveListener(OnDeath);
    }

    private void OnDeath()
    {
        isDead = true;
    }

    public override bool Validate()
    {
        return isDead;
    }
}
