using System;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    [Serializable]
    public class GamePauseState : State
    {
        public override void OnEnter()
        {
            Debug.Log("GamePauseState");
        }

        public override void OnExit()
        {
        }

        public override void Update(Context c)
        {
            //Can transition into GameRunningState, IntroStartState, or ExitState
        }
    }
}