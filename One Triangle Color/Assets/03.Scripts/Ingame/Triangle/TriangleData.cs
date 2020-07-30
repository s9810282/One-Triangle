using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Triangles
{
    [System.Serializable]
    public struct TriangleData
    {
        public string tag;

        public float x;
        public float y;

        public float rotateX;


        public Vector3 position;
        public Quaternion rotation;

        public TriangleType triangleType;
    }
}
