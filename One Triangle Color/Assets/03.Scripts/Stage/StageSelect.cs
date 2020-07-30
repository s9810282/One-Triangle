using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Map;

public class StageSelect : MonoBehaviour
{
    [SerializeField] StageMapData[] stageMapDatas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stage_1_1()
    {
        GameManager.Instance.CurrentStageMapData = stageMapDatas[0];
    }

    public void Stage_1_2()
    {
        GameManager.Instance.CurrentStageMapData = stageMapDatas[1];
    }

    public void Stage_1_3()
    {
        GameManager.Instance.CurrentStageMapData = stageMapDatas[2];
    }

    public void MoveScene()
    {
        SceneManager.LoadScene("Loading");
    }
}
