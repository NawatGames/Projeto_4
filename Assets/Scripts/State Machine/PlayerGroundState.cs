using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundState : PlayerBaseState
{
    public override void Enter()
    {
        Debug.Log("Ground State");
        context = gameObject.GetComponent<PlayerStateController>();
    }
    public override void Do()
    {
    }
    public override void FixedDo()
    {
    }
    public override void CheckSwitchState(PlayerBaseState actualState)
    {
    }

    public override void Exit(PlayerBaseState newState)
    {
    }


    public override void SubState(PlayerBaseState actualSubState)
    {
    }
}
