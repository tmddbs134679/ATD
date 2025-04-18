using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    [field: SerializeField]public InputReader InputReader { get; private set; }
    [field: SerializeField] public CharacterController Controller { get; private set; }

    [field: SerializeField] public Animator Animator { get; private set; }

    [field: SerializeField] public ForceReceiver ForceReceiver { get; private set; }
    [field: SerializeField] public Targeter Targeter { get; private set; }
    [field: SerializeField] public float FreeLookMovementSpeed { get; private set; }
    [field: SerializeField] public float RotationDamping { get; private set; }

    [field: SerializeField] public Attack[] Attaks { get; private set; }
    // Start is called before the first frame update
    private void Start()
    {
        SwitchState(new PlayerFreeLookState(this));
    }


}
