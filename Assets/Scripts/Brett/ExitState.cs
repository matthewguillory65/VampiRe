using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditorInternal;
using UnityEngine;

namespace Assets.Scripts.Brett
{

    [System.Serializable]

    public class ExitState : State
    {
        public override void OnEnter()
        {
            //Close Application

            Debug.Log("ExitState");
        }

        public override void OnExit()
        {

        }

        public override void Update(Context c)
        {

        }
    }
}
