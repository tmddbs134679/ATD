using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public abstract class PlayerBaseState : State
{
    protected PlayerStateMachine stateMachine;

    public PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;   
    }

    protected void Move(float deltaTime)
    {
        Move(Vector3.zero, deltaTime);
    }

    protected void Move(Vector3 motion, float deltaTime)
    {
        stateMachine.Controller.Move((motion + stateMachine.ForceReceiver.Movement) * deltaTime);
    }

    protected void FaceTarget()
    {
        if(stateMachine.Targeter.CurrentTarget == null) { return; }

        Vector3 lookPos = stateMachine.Targeter.CurrentTarget.transform.position - stateMachine.transform.position;

        lookPos.y = 0f;

        stateMachine.transform.rotation = Quaternion.LookRotation(lookPos);
    }

    protected void Dodge()
    {
        if(stateMachine.CanDodge)
        {
            stateMachine.SwitchState(stateMachine.States[Define.EPLAYERSTATE.DODGE]);
            UpdateLastDodgeTime();
        }
      
    }
    protected Vector3 CalculateMovement()
    {
        Vector3 movement = new Vector3();

        movement.x = GameManager.Inst.JoystickDir.x;
        movement.y = 0;
        movement.z = GameManager.Inst.JoystickDir.y;

        return movement;
    }

    public void UpdateLastDodgeTime()
    {
        stateMachine.lastDodgeTime = Time.time;
    }
}
