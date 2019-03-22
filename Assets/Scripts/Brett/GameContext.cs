﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    [CreateAssetMenu]
    public class GameContext :  Context
    {
        public string StateName;


        public override State CurrentState { get; set; }

        public override void ChangeState(State s)
        {
            CurrentState.OnExit();
            CurrentState = s;
            CurrentState.OnEnter();
        }

        public override void Update()
        {
            StateName = CurrentState.ToString();
            CurrentState.Update(this);
        }
    }
}
