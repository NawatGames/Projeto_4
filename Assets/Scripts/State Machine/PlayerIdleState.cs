using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public override void CheckSwitchState(PlayerBaseState actualState)
    {
        Debug.Log("Idle State");
        context = gameObject.GetComponent<PlayerStateController>();
    }

    public override void Do()
    {
    }

    public override void Enter()
    {
    }

    public override void Exit(PlayerBaseState newState)
    {
    }

    public override void FixedDo()
    {
    }

    public override void SubState(PlayerBaseState actualSubState)
    {
    }
}
