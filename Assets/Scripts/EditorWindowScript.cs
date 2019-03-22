using System.Collections.Generic;
using System.Reflection;
using Assets.Scripts.Brett;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(EditorGUILayout)) ]
public class EditorWindowScript  :  Editor
{
    public bool onTriggerEnterToggle;
    public bool onTriggerExitToggle;
    public bool onTriggerStayToggle;
    public GameEvent OnTriggerEnter;
    public GameEvent OnTriggerExit;
    public GameEvent OnTriggerStay;
    public override void OnInspectorGUI()
    {
        onTriggerEnterToggle = EditorGUILayout.Toggle("On Trigger Enter", onTriggerEnterToggle);
        onTriggerExitToggle = EditorGUILayout.Toggle("On Trigger Exit", onTriggerExitToggle);
        onTriggerStayToggle = EditorGUILayout.Toggle("On Trigger Stay", onTriggerStayToggle);
        base.OnInspectorGUI();
    }

    private void RasieEvents()
    {
        if (onTriggerEnterToggle == true)
        {
            OnTriggerEnter.Raise();
        }

        if (onTriggerExitToggle == true)
        {
            OnTriggerExit.Raise();
        }

        if (OnTriggerStay == true)
        {
            OnTriggerStay.Raise();
        }
    }

    void Start()
    {

    }

    void Update()
    {
        RasieEvents();
    }
}
