using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Map;
using Triangles;

public class ResourceManager
{
    private static ResourceManager instance;
    public static ResourceManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ResourceManager();
                instance.Init();
            }

            return instance;
        }
    }

    Dictionary<TriangleType, GameObject> tagToTriangles;

    // Start is called before the first frame update
    public void Init()
    {
        tagToTriangles = new Dictionary<TriangleType, GameObject>();

        tagToTriangles.Add(TriangleType.Blue, Resources.Load("Triangle_Blue") as GameObject);
        tagToTriangles.Add(TriangleType.Red, Resources.Load("Triangle_Red") as GameObject);
    }


    public GameObject ReturnTriangle(TriangleType type)
    {
        return tagToTriangles[type];
    }
}
