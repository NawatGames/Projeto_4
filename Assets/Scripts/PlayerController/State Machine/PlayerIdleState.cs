using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public override void Enter()
    {
        Debug.Log("Idle State");
        context = playerObj.GetComponentInChildren<PlayerStateController>();
        movement.Idle();
    }
    public override void CheckSwitchState(PlayerBaseState actualState)
    {

    }

    public override void Do()
    {
        CheckSwitchState(this);
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
