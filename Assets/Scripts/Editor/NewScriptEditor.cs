using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(NewScript))]
public class NewScriptEditor : Editor
{
    SerializedProperty gameObject;

    bool showState;
    bool showBase;

    private void OnEnable()
    {
        gameObject = serializedObject.FindProperty("go");
    }

    public override void OnInspectorGUI()
    {
        NewScript newScript = (NewScript)target;

        GUIStyle boolStyle = new GUIStyle(EditorStyles.label);

        EditorGUILayout.Space();

        showState = EditorGUILayout.Foldout(showState, "State Inspector",true, EditorStyles.toolbarDropDown);
        if(showState)
        {
            EditorGUILayout.BeginVertical(EditorStyles.textField);
            EditorGUI.indentLevel = 1;

            if(!newScript.isTrue) boolStyle.normal.textColor = Color.red;
            else boolStyle.normal.textColor = Color.green;
            EditorGUILayout.LabelField("BOOLEANO DE COLOR", boolStyle);

            newScript.entero = EditorGUILayout.IntField("Entero:", newScript.entero);
            newScript.dec = EditorGUILayout.FloatField("Float:", newScript.dec);
            newScript.frase = EditorGUILayout.TextField("Fraseeeeee", newScript.frase);
            newScript.isTrue = EditorGUILayout.Toggle("ES VERDÁ", newScript.isTrue);
            newScript.vector = EditorGUILayout.Vector2Field("Vectorr", newScript.vector);
            EditorGUILayout.PropertyField(gameObject);

            EditorGUILayout.EndVertical();

            if(GUILayout.Button("Escribir frase"))
            {
                newScript.EscribirFrase();
            }
        }
        EditorGUI.indentLevel = 0;
        EditorGUILayout.Space();
        showBase = EditorGUILayout.Foldout(showBase, "Base Inspector", true);
        if(showBase)
        {
            EditorGUI.indentLevel = 1;
            base.OnInspectorGUI();
        }
    }

}
