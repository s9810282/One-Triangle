using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Triangles;


namespace Map
{
    [CreateAssetMenu(fileName = "new MapData", menuName = "Stage Map Data", order = 2)]
    public class StageMapData : ScriptableObject
    {
        public List<TriangleData> triangles = new List<TriangleData>();       //only triangle
    }
}



//스테이지 씬에 기본적인 배경 및 구조를 배치해두고
//삼각형들의 위치만 로드시킴
