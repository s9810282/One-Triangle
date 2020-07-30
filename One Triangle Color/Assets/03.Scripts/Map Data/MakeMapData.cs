using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Triangles;

namespace Map
{
    public class MakeMapData : MonoBehaviour
    {
        public StageMapData mapData;

        public void Save()
        {
            Triangle[] triangles = FindObjectsOfType<Triangle>();

            ClearData();

            foreach (var item in triangles)
            {
                item.ResetDictionary();
                item.SetData();
                mapData.triangles.Add(item.TriangleData);
            }

        } 

        public void Load()
        {
            ClearMap();

            List<TriangleData> triangles = mapData.triangles;

            foreach (var item in triangles)
            {
                GameObject triangle = Instantiate(ResourceManager.Instance.ReturnTriangle(item.triangleType));

                triangle.tag = item.tag;
                triangle.transform.position = new Vector3(item.x, item.y, 0);
                triangle.transform.rotation = new Quaternion(item.rotateX, 0, 0, 0);
            }
        }

        public void ClearData()
        {
            mapData.triangles.Clear();
            Debug.Log("Clear");
        }

        public void ClearMap()
        {
            Triangle[] triangles = FindObjectsOfType<Triangle>();

            foreach (var item in triangles)
            {
                DestroyImmediate(item.gameObject);
            }
        }
    }
}
