using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAirborneState : PlayerBaseState
{
    public override void Enter()
    {
        Debug.Log("Airborne State");
        context = playerObj.GetComponentInChildren<PlayerStateController>();
        movement.Jump();
    }
    public override void Do()
    {
        CheckSwitchState(this);
    }
    public override void FixedDo()
    {
    }
    public override void CheckSwitchState(PlayerBaseState actualState)
    {
       if(context.isGrounded && movement.body2D.velocity.y == 0)
       {
            PlayerBaseState newState = playerObj.GetComponentInChildren<PlayerGroundState>();
            actualState.Exit(newState);
       }
    }

    public override void Exit(PlayerBaseState newState)
    {
        context.superState = newState;
        context.superState.Enter();
    }


    public override void SubState(PlayerBaseState actualSubState)
    {
    }
}
