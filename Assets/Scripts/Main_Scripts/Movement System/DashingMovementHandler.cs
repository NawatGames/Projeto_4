using System;
using System.Collections;
using System.Collections.Generic;
using EventSystem.SimpleEvents;
using UnityEngine;

public class DashingMovementHandler : MonoBehaviour
{
    [SerializeField] private DashingController dashingController;
    [SerializeField] BoolEvent dashingChangedEvent;
    [SerializeField] private Vector2Event movementDirectionEvent;
    [SerializeField] private DashVerifier dashVerifier;

    private Vector2 _movementDirection;


    private void OnEnable()
    {
        dashingChangedEvent.SubscribeUnityEvent(OnDashingChanged);
        movementDirectionEvent.SubscribeUnityEvent(OnMovementDirectionChanged);
    }

    private void OnMovementDirectionChanged(Vector2 arg0)
    {
        _movementDirection = arg0;
    }

    private void OnDisable()
    {
        dashingChangedEvent.UnsubscribeUnityEvent(OnDashingChanged);
        movementDirectionEvent.UnsubscribeUnityEvent(OnMovementDirectionChanged);

    }

    private void OnDashingChanged(bool arg0)
    {
        if (_movementDirection != Vector2.zero)
        {
            if (arg0)
            {
                if (dashVerifier.Verify())
                {
                    dashingController.DoDash(_movementDirection);
                }
                
            }
        }

    }
}
