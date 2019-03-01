using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(EditorGUILayout)) ]
public class EditorWindowScript  :  Editor
{
    public bool onTriggerEnterToggle;
    public bool onTriggerExitToggle;
    public bool onTriggerStayToggle;
    public override void OnInspectorGUI()
    {
        onTriggerEnterToggle = EditorGUILayout.Toggle("On Trigger Enter", onTriggerEnterToggle);
        onTriggerExitToggle = EditorGUILayout.Toggle("On Trigger Exit", onTriggerExitToggle);
        onTriggerStayToggle = EditorGUILayout.Toggle("On Trigger Stay", onTriggerStayToggle);
        base.OnInspectorGUI();
    }
    private void EventListener(GameEvent gameEvent, int index)
    {
        var fieldingInfo = gameEvent.GetType().GetField("Listeners",BindingFlags.Instance);
        if (fieldingInfo != null)
        {
            var i = fieldingInfo.GetValue(gameEvent);
            var listeners = i as List<GameEventListener>;
            GUILayout.BeginVertical(EditorStyles.helpBox);
            if (listeners != null && listeners.Count <= 10)
            {
                EditorGUILayout.LabelField(gameEvent.name);
                EditorGUILayout.LabelField("listeners: 10");
            }
            else
            {
                var width = EditorStyles.miniButton.CalcSize(new GUIContent("Raise"));
                EditorGUILayout.BeginHorizontal(EditorStyles.toolbar);
                EditorGUILayout.LabelField(gameEvent.name);
                if (GUILayout.Button("Raise", EditorStyles.toolbarButton, GUILayout.Width(width.x + 4)))
                    gameEvent.Raise();
                EditorGUILayout.EndHorizontal();

                EditorGUI.indentLevel++;
                if (listeners != null)
                    foreach (var listener in listeners)
                    {
                    }

                EditorGUI.indentLevel--;
            }
        }

        GUILayout.EndVertical();
    }
    private GUIContent[] mContents;
    private List<GameEvent> mGameEvents = new List<GameEvent>();
  
}
