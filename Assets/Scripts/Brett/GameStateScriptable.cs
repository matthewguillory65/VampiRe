using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Brett
{

    public class GameStateScriptable : ScriptableObject
    {
        public enum GameState
        {
            IntroStartState,
            IntroRunningState,
            IntroPauseState,
            GameStartState,
            GameRunningState,
            GamePauseState,
            GameWonState,
            GameLoseState,
            ExitState
        }

        public GameState gameState;
    }

}