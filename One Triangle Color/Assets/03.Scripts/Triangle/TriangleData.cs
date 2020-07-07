using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Triangles
{
    [System.Serializable]
    public struct TriangleData
    {
        //sprite = triangle type.sprite
       
        public string tag;

        //transform.position
        public float x;
        public float y;

        //tramform.rotate
        public float rotateX;


        public Vector3 position;
        public Quaternion rotation;

        //what triangle?
        public TriangleType triangleType;
    }
}
