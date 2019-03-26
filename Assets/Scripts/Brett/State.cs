using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    public abstract class State
    {
        public abstract void OnEnter();

        public abstract void OnExit();

        public abstract void Update(Context c, ConditionScriptable conditionScriptable);
    }
}
