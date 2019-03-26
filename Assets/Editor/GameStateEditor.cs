using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Assets.Scripts.Brett;
using UnityEditor;
using UnityEditor.VersionControl;
using UnityEngine;


public class GameStateEditor : EditorWindow
{
    [MenuItem("Tools/GameStateEditor")]
    private static void Init()
    {
        var w = GetWindow(typeof(GameStateEditor));
        w.Show();
    }

    private void OnEnable()
    {
        gameStates = new List<System.Type>();
        var assemblies = System.AppDomain.CurrentDomain.GetAssemblies();
        foreach (var assembly in assemblies)
        {
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (type.IsSubclassOf(typeof(State)))
                {
                    gameStates.Add(type);
                }
            }
        }

        var assets = AssetDatabase.FindAssets("t:GameEvent").Select(guid => AssetDatabase.GUIDToAssetPath(guid))
            .Select(path => AssetDatabase.LoadAssetAtPath<GameEvent>(path)).Where(gameevent => gameevent).ToList();
        foreach (var a in assets)
        {
            gameEvents.Add(a.name);
        }
    }

    private void OnGUI()
    {
        GUILayout.BeginHorizontal(EditorStyles.helpBox);
        GUILayout.BeginVertical(EditorStyles.helpBox);
        EditorGUILayout.LabelField("Game States:", EditorStyles.boldLabel);
        scroll = EditorGUILayout.BeginScrollView(scroll);
        for (int i = 0; i < gameStates.Count; i++)
        {
            EditorGUILayout.LabelField(gameStates[i].Name);
        }


        GUILayout.EndVertical();
        EditorGUILayout.EndScrollView();

        GUILayout.BeginVertical();
        scroll2 = EditorGUILayout.BeginScrollView(scroll2);
        EditorGUILayout.LabelField("Game State Name", EditorStyles.boldLabel);
        gameStateName = GUILayout.TextField(gameStateName);

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Transition Conditions", EditorStyles.boldLabel);
        
        //EditorGUILayout.Popup(0, (Array)gameEvents)


        if (GUILayout.Button("Create a New GameState") && gameStateName != "")
        {
            string path = "Assets/Scripts/Brett/" + gameStateName + ".cs";
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine("using UnityEngine;\n" +
                             "\n" +
                             "namespace Assets.Scripts.Brett\n" +
                             "{\n" +
                             "\t[System.Serializable]\n" +
                             "\tpublic class " + gameStateName + " : State\n" + 
                             "\t{\n" +
                             "\t\tpublic override void OnEnter()\n" + 
                             "\t\t{\n\t\t}\n\n" + 
                             "\t\tpublic override void OnExit()\n" +
                             "\t\t{\n\t\t}\n\n" +
                             "\t\tpublic override void Update(Context c)\n" +
                             "\t\t{\n\t\t}\n" +
                             "\t}\n}");
           writer.Close();
           AssetDatabase.Refresh();
           Repaint();
            
        }
        GUILayout.EndScrollView();
        GUILayout.EndVertical();
        GUILayout.EndHorizontal();

        if (GUI.changed)
        {
            Repaint();
        }
    }

    private List<System.Type> gameStates = new List<System.Type>();
    private List<string> gameEvents = new List<string>();

    private Vector2 scroll;
    private Vector2 scroll2;


    private string gameStateName;

}
