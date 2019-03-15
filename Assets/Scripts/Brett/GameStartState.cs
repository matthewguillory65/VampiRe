using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditorInternal;
using UnityEngine;

namespace Assets.Scripts.Brett
{

    public class GameStartState : State
    {
        public override void OnEnter()
        {
            Debug.Log("GameStartState");
        }

        public override void OnExit()
        {

        }

        public override void Update(Context c)
        {
            //Transitions into GameRunningState
        }
    }
}
