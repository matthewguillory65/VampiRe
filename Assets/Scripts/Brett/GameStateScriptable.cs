using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;

#endif
namespace Assets.Scripts.Brett
{
    [CreateAssetMenu(menuName = "GameStateScriptable")]
    public class GameStateScriptable : ScriptableObject
    {
        public State TheState { get; set; }

        public string stateID
        {
            get { return TheState == null ? "null" : TheState.GetHashCode().ToString(); }
        }
    }
#if UNITY_EDITOR
    [CustomEditor(typeof(GameStateScriptable))]
    public class GameStateScriptableInspector : Editor
    {
        public State _State;
        public string SelectionState;
        public List<string> StateTypeNames = new List<string>();
        public List<Type> StateTypes = new List<Type>();
        private GameStateScriptable mt;

        private void OnEnable()
        {
            var assembly = GetType().Assembly;
            var baseType = typeof(State);
            StateTypes = assembly.GetTypes().Where(stateType => baseType.IsAssignableFrom(stateType)).ToList();
            mt = target as GameStateScriptable;
            SelectionState = mt.TheState == null ? "Select State" : mt.TheState.ToString();
        }

        public override void OnInspectorGUI()
        {
            if (EditorGUILayout.DropdownButton(new GUIContent {text = SelectionState}, FocusType.Passive))
            {
                var gm = new GenericMenu();
                StateTypes.ForEach(
                    s => gm.AddItem(new GUIContent {text = s.Name}, false,
                        () =>
                        {
                            SelectionState = s.Name;
                            mt.TheState = Activator.CreateInstance(s) as State;
                            _State = mt.TheState;
                            EditorUtility.SetDirty(mt);
                      
                        }));
                gm.ShowAsContext();
            }


            EditorGUILayout.LabelField(mt.stateID);
        }
    }
#endif
}