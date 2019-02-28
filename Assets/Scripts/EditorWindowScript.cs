using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(OnTriggerEventSystem))]
public class EditorWindowScript : Editor
{
    public bool onTriggerEnterToggle;
    public bool onTriggerExitToggle;
    public bool onTriggerStayToggle;

    public override void OnInspectorGUI()
    {
        onTriggerEnterToggle = EditorGUILayout.Toggle("On Trigger Enter", onTriggerEnterToggle);
        if (onTriggerEnterToggle == true)
        {
            
        }
       onTriggerExitToggle = EditorGUILayout.Toggle("On Trigger Exit", onTriggerExitToggle);
        onTriggerStayToggle = EditorGUILayout.Toggle("On Trigger Stay", onTriggerStayToggle);
        base.OnInspectorGUI();


    }

}
