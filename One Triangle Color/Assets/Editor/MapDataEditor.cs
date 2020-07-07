﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

using Map;

[CustomEditor(typeof(MakeMapData))]
public class MapDataEditor : Editor
{
    MakeMapData mapData;
    SerializedProperty makeMapData;

    // Start is called before the first frame update
    void OnEnable()
    {
        mapData = target as MakeMapData;
        makeMapData = serializedObject.FindProperty("mapData");
    }

    public override void OnInspectorGUI()
    {
        #region Example

        //(MonsterType)EditorGUILayout.EnumPopup("", monster.monsterType);


        //EditorGUILayout.FloatField("", monster.hp);


        //EditorGUILayout.FloatField("", monster.atk);
        //EditorGUILayout.TextField("", monster.name);

        //EditorGUI.DrawPreviewTexture(Rect.zero, monster.sprite);
        //EditorGUILayout.BeginHorizontal();
        //EditorGUILayout.LabelField("");

        //EditorGUILayout.ObjectField(monster.sprite, typeof(Sprite), false, new[] { GUILayout.Width(64), GUILayout.Height(64) }) as Sprite;
        //monster.sprite = EditorGUILayout.ObjectField(monster.sprite, typeof(Sprite), false) as Sprite;

        //EditorGUILayout.EndHorizontal();

        //EditorGUILayout.Slider("value", monster.value, 0f, 1f);

        #endregion

        serializedObject.Update();
        EditorGUILayout.PropertyField(makeMapData);
        serializedObject.ApplyModifiedProperties();

        

        if (GUILayout.Button("SAVE"))
        {
            Debug.Log("SAVE");
            mapData.Save();
        }

        if (GUILayout.Button("Load"))
        {
            Debug.Log("Load");
            mapData.Load();
        }

        if (GUILayout.Button("Clear Data"))
        {
            Debug.Log("Clear Data");
            mapData.ClearData();
        }

        if (GUILayout.Button("Clear Map"))
        {
            Debug.Log("Clear Map");
            mapData.ClearMap();
        }

    }
}