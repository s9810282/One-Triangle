using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Triangles;


namespace Map
{
    [CreateAssetMenu(fileName = "new MapData", menuName = "Stage Map Data", order = 2)]
    public class StageMapData : ScriptableObject
    {
        public List<TriangleData> triangles = new List<TriangleData>();
    }
}