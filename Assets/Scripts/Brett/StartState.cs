using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditorInternal;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    public class StartState : State
    {
        public override void OnEnter()
        {
            Debug.Log("StartState");
        }

        public override void OnExit()
        {

        }

        public override void Update(Context c)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                c.ChangeState(new RunningState());
            }
        }
    }
}
