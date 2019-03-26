using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Brett;
using UnityEngine;

namespace Assets.Scripts.Brett
{

    [System.Serializable]
    public class GameLoseState : State
    {
        public override void OnEnter()
        {
            Debug.Log("GameLoseState");
        }

        public override void OnExit()
        {

        }

        public override void Update(Context c, ConditionScriptable conditionScriptable)
        {
            //Can Transition into ExitState or IntroStartState
        }
    }
}
