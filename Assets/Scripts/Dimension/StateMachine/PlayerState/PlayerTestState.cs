using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestState : PlayerBaseState
{

    public PlayerTestState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
       
    }

    public override void Exit()
    {
        
    }

    public override void Tick(float deltaTime)
    {
        Vector3 movment = new Vector3();
        movment.x = stateMachine.InputReader.MovementValue.x;
        movment.y = 0;
        movment.z = stateMachine.InputReader.MovementValue.y;
        stateMachine.Controller.Move(movment * stateMachine.FreeLookMovementSpeed * deltaTime);

        if (stateMachine.InputReader.MovementValue == Vector2.zero)
        {
            stateMachine.Animator.SetFloat("FreeLookSpeed", 0, 0.1f, deltaTime);
            return;
        }

        stateMachine.Animator.SetFloat("FreeLookSpeed", 1, 0.1f, deltaTime);
        stateMachine.transform.rotation = Quaternion.LookRotation(movment);
    }

}
