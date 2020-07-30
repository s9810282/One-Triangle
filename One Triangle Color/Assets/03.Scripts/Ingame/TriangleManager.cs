using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Triangles;

public class TriangleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadStage()
    {
        Debug.Log("LoadStage");
        Load();
    }

    public void Load()
    {
        ClearMap();

        Debug.Log("Load");
        List<TriangleData> triangles = GameManager.Instance.CurrentStageMapData.triangles;

        foreach (var item in triangles)
        {
            Debug.Log(item.position);
            GameObject triangle = GameObject.Instantiate(ResourceManager.Instance.ReturnTriangle(item.triangleType));

            triangle.tag = item.tag;
            triangle.transform.position = new Vector3(item.x, item.y, 0);
            triangle.transform.rotation = new Quaternion(item.rotateX, 0, 0, 0);
        }
    }

    public void ClearMap()
    {
        Triangle[] triangles = GameObject.FindObjectsOfType<Triangle>();

        foreach (var item in triangles)
        {
            GameObject.Destroy(item.gameObject);
        }
    }
}
