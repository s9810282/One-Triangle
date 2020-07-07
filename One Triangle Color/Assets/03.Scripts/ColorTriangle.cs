using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

using Map;
using Triangles;

public class ColorTriangle : Triangle, IPointerDownHandler, IPointerUpHandler, IBeginDragHandler, IEndDragHandler
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void OnMouseDown()
    //{
    //    Debug.Log("Mouse Down");
    //}

    //public void OnMouseDrag()
    //{
    //    Debug.Log("Mouse Drag");
    //}

    //public void OnMouseUp()
    //{
    //    Debug.Log("Mouse up");
    //}

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Point Down");
        throw new System.NotImplementedException();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        throw new System.NotImplementedException();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        throw new System.NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Point Up");
        throw new System.NotImplementedException();
    }
}
