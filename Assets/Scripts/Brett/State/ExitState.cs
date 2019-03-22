using System;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    [Serializable]
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