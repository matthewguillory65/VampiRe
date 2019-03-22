using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Brett;
using UnityEngine;

public class MyContext : Context
{
    public override State CurrentState { get; set; }

    public override void ChangeState(State s)
    {
        CurrentState.OnExit();
        CurrentState = s;
        CurrentState.OnEnter();
    }

    public override void Update()
    {
        CurrentState.Update(this);
    }
}