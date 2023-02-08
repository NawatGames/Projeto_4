using System;
using System.Collections;
using System.Collections.Generic;
using EventSystem.SimpleEvents;
using Unity.VisualScripting;
using UnityEngine;

public class FlipAnimationHandler : MonoBehaviour
{
    [SerializeField] private Vector2Event movementDirectionEvent;
    [SerializeField] private GameObject spriteRoot;

    private void OnEnable()
    {
        movementDirectionEvent.SubscribeUnityEvent(OnInputDirectionChanged);
    }

    private void OnDisable()
    {
        movementDirectionEvent.UnsubscribeUnityEvent(OnInputDirectionChanged);
    }

    private void OnInputDirectionChanged(Vector2 inputDirection)
    {
        if (inputDirection.x > 0)
        {
            spriteRoot.transform.eulerAngles = new Vector3(0,0,0);

        }

        if (inputDirection.x < 0)
        {
            spriteRoot.transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}
