using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditorInternal;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    [System.Serializable]
    public class IntroPauseState : State
    {

        public override void OnEnter()
        {
            Debug.Log("IntroPauseState");
        }

        public override void OnExit()
        {

        }

        public override void Update(Context c)
        {
            //Can transition into IntroRunningState, or ExitState
        }
    }
}
