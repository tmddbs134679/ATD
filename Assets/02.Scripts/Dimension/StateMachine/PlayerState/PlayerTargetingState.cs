using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerTargetingState : PlayerBaseState
{
    public PlayerTargetingState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        stateMachine.InputReader.CancelEvent += OnCancel;
    }
    public override void Tick(float deltaTime)
    {

        FaceTarget();

        if (stateMachine.InputReader.IsAttacking)
        {
            stateMachine.SwitchState(stateMachine.States[EPLAYERSTATE.FREELOOK]);
            return;
        }

        if(stateMachine.Targeter.CurrentTarget == null)
        {
            stateMachine.SwitchState(stateMachine.States[EPLAYERSTATE.FREELOOK]);
            return;
        }

        // �����Ҷ� target�ϰ�
     
    }

    public override void Exit()
    {
        stateMachine.InputReader.CancelEvent += OnCancel;
    }

    private void OnCancel()
    {
        stateMachine.Targeter.Cancel();

        stateMachine.SwitchState(stateMachine.States[EPLAYERSTATE.FREELOOK]);
    }
    
}
