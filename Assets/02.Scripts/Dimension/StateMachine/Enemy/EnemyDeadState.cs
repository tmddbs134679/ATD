using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeadState : EnemyBaseState
{
    private readonly int DeadHas = Animator.StringToHash("Dead");
    private const float AnimatorDampTime = 0.1f;
    private const float CrossFadeDuration = 0.1f;
    public EnemyDeadState(EnemyStateMachine stateMachine) : base(stateMachine){ }

    public override void Enter()
    {
        if(stateMachine.Weapon != null)
        stateMachine.Weapon.gameObject.SetActive(false);

        stateMachine.Animator.CrossFadeInFixedTime(DeadHas, CrossFadeDuration);

       GameObject.Destroy(stateMachine.Target);
    }

    public override void Tick(float deltaTime)
    {
       
    }

    public override void Exit()
    {
        
    }
}
