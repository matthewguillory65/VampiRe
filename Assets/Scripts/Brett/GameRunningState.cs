using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Brett;
using UnityEditor.VersionControl;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    [System.Serializable]
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
