using System;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    [Serializable]
    public class GameRunningState : State
    {
        public override void OnEnter()
        {
            Debug.Log("GameRunningState");
        }

        public override void OnExit()
        {
        }

        public override void Update(Context c, ConditionScriptable conditionScriptable)
        {
            //Can Transition into GamePauseState, GameWinState, or GameLoseState
        }
    }
}