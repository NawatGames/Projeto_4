using System;
using System.Collections;
using System.Collections.Generic;
using EventSystem.SimpleEvents;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] private HealthSystem.HealthSystem healthSystem;
    [SerializeField] private IntegerEvent healthChangedEvent;
    [SerializeField] private Slider _healthSlider;

    private void OnEnable()
    {
        healthChangedEvent.SubscribeUnityEvent(OnHealthChanged);
    }

    private void OnHealthChanged(int arg0)
    {
        _healthSlider.value = arg0;
    }

    private void OnDisable()
    {
        healthChangedEvent.UnsubscribeUnityEvent(OnHealthChanged);

    }
}
