using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Triangles;

namespace Map
{
    public class MakeMapData : MonoBehaviour
    {
        public StageMapData mapData;

        // Start is called before the first frame update
        void Start()
        {

        }
        // Update is called once per frame
        void Update()
        {

        }

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
        //삼각형들만 받아와서 저장 
        //삼각형을 제외한 스테이지의 구성요소들은 스테이지 씬에 배치되어잇을 예정

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

                //triangle.transform.position = item.position;
                //triangle.transform.rotation = item.rotation;
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
