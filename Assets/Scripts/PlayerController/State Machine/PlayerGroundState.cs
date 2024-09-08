using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundState : PlayerBaseState
{
    public override void Enter()
    {
        Debug.Log("Ground State");
        context = playerObj.GetComponentInChildren<PlayerStateController>();
        movement.Ground();
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
        if (context.movementInput.y > 0)
        {
            PlayerBaseState newState = playerObj.GetComponentInChildren<PlayerAirborneState>();
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
