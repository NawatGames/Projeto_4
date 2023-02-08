using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PlayerStateMachineSystem;
using Unity.VisualScripting;
using UnityEngine;

public class StateAnimationHandler : MonoBehaviour
{
     private List<MemberAnimationHandler> memberAnimationHandlers;
     private List<BackFootAnimationHandler> backFootAnimationHandlers;
     private List<FrontFootAnimationHandler> frontFootAnimationHandlers;

     private List<Animator> animators;

    [SerializeField] private PlayerStateMachineEventHandler playerStateMachineEventHandler;

    [SerializeField] private GameObject playerRoot;
    [SerializeField] private GameObject spriteRoot;
    

    private void Awake()
    {
        memberAnimationHandlers = playerRoot.GetComponentsInChildren<MemberAnimationHandler>().ToList(); 
        frontFootAnimationHandlers = playerRoot.GetComponentsInChildren<FrontFootAnimationHandler>().ToList();
        backFootAnimationHandlers= playerRoot.GetComponentsInChildren<BackFootAnimationHandler>().ToList();

        animators = spriteRoot.GetComponentsInChildren<Animator>().ToList();
    }

    private void OnEnable()
    {
        playerStateMachineEventHandler.StateChanged.AddListener(OnStateChanged);
    }

    private void OnStateChanged(PlayerState newState)
    {
        foreach (var memberAnimationHandler in memberAnimationHandlers)
        {
            memberAnimationHandler.enabled = newState.stateName == memberAnimationHandler.AnimationState;
        }

        foreach (var backFootAnimationHandler in backFootAnimationHandlers)
        {
            backFootAnimationHandler.enabled = newState.stateName == backFootAnimationHandler.AnimationState;
        }
        foreach (var frontFootAnimationHandler in frontFootAnimationHandlers)
        {
            frontFootAnimationHandler.enabled = newState.stateName == frontFootAnimationHandler.AnimationState;
        }

        foreach (var animator in animators)
        {
            foreach (var animatorControllerParameter in animator.parameters)
            {
                animator.SetBool(animatorControllerParameter.name,false);
            }

            foreach (var animatorParameter in animator.parameters)
            {
                if (animatorParameter.name == newState.stateName)
                {
                    animator.SetBool(animatorParameter.name, true);
                }
            }
            ;
        }
    }

    private void OnDisable()
    {
        playerStateMachineEventHandler.StateChanged.RemoveListener((OnStateChanged));
    }
}
