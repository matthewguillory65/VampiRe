using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Brett;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    public class RunningState : State
    {

        public override void OnEnter()
        {
            Debug.Log(this);
        }

        public override void OnExit()
        {

        }

        public override void Update(Context c)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                c.ChangeState(new StartState());
            }
        }
    }
}
