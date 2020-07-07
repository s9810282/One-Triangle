using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Map;
using Triangles;

public class Triangle : MonoBehaviour
{
    [SerializeField] TriangleData triangleData;

    public TriangleData TriangleData { get { return triangleData; } set { triangleData = value; } }

    protected Dictionary<string, TriangleType> tagToTriangleType;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ResetDictionary()
    {
        tagToTriangleType = new Dictionary<string, TriangleType>();

        tagToTriangleType.Add("Blue", TriangleType.Blue);
        tagToTriangleType.Add("BlueRed", TriangleType.BlueRed);
        tagToTriangleType.Add("Red", TriangleType.Red);

        tagToTriangleType.Add("Yellow", TriangleType.Yellow);
        tagToTriangleType.Add("YellowGreen", TriangleType.YellowGreen);
        tagToTriangleType.Add("Green", TriangleType.Grren);

        tagToTriangleType.Add("TP", TriangleType.TP);

        tagToTriangleType.Add("Minus", TriangleType.Minus);
        tagToTriangleType.Add("Devide", TriangleType.Devide);
    }

    public void SetData()
    {
        Debug.Log("SetData");
        triangleData.tag = transform.tag;

        triangleData.x = transform.position.x;
        triangleData.y = transform.position.y;

        triangleData.rotateX = transform.rotation.x;

        triangleData.position = transform.position;
        triangleData.rotation = transform.rotation;

        triangleData.triangleType = tagToTriangleType[transform.tag];
    }
}
