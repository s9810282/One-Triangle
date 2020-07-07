using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

using Triangles;
using Map;

public class SampleWindow : EditorWindow
{
    public MakeMapData mapData;

    StageMapData[] mapDatas;

    bool isSave;

    [MenuItem("Tools/Save")]
    static void Save()
    {
        
    }

    [MenuItem("Tools/Load")]
    static void Load()
    {

    }

    private void OnGUI()
    {
        mapDatas = Resources.LoadAll<StageMapData>("MapData");

        var style = new GUIStyle(GUI.skin.button);

        

        for (int i = 0; i < mapDatas.Length; i++)
        {       
            if (GUILayout.Button(mapDatas[i].name))
            {
                mapData.mapData = mapDatas[i];

                if (isSave)
                    mapData.Save();
                else
                    mapData.Load();
            }
        }
    }

    public void OpenLoadWindow()
    {
        isSave = false;

        SampleWindow window = (SampleWindow)EditorWindow.GetWindow(typeof(SampleWindow), false, "LoadMapDataList");
        window.title = "Load Map Data List";
        window.Show();
    }

    public void OpenSaveWindow()
    {
        isSave = true;

        SampleWindow window = (SampleWindow)EditorWindow.GetWindow(typeof(SampleWindow), false, "Save Map Data List");
        window.title = "Save Map Data List";
        window.Show();
    }
}
