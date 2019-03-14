using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Brett;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    public class GameRunningState : State
    {

        public override void OnEnter()
        {
            Debug.Log("GameRunningState");
        }

        public override void OnExit()
        {

        }

        public override void Update(Context c)
        {
            //Can Transition into GamePauseState
        }
    }
}
