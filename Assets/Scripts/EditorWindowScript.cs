using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(OnTriggerEventSystem))]
public class EditorWindowScript : Editor {
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (EditorGUILayout.Toggle("On Trigger Enter", false))
        {

        }
        if (EditorGUILayout.Toggle("On Trigger Exit", false))
        {
            
        }
        if (EditorGUILayout.Toggle("On Trigger Stay", false))
        {

        }
    }
 
    

}
