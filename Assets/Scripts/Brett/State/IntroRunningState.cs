using System;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    [Serializable]
    public class IntroRunningState : State
    {
        public override void OnEnter()
        {
            Debug.Log("IntroRunningState");
        }

        public override void OnExit()
        {
        }

        public override void Update(Context c)
        {
            //Can transition to IntroPauseState, IntroRunningState, or GameStart state
        }
    }
}