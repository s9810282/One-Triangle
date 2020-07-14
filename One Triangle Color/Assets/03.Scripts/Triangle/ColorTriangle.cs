using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

using Map;
using Triangles;

public class ColorTriangle : Triangle//, IPointerDownHandler, IPointerUpHandler, IBeginDragHandler, IEndDragHandler
{
    Vector3 startTouch;
    Vector3 endTouch;

    Vector3 rotateValue = new Vector3(180f, 0f, 0f);

    Vector3 yMovePos;
    Vector3 xMovePos;

    // Start is called before the first frame update
    void Start()
    {
        yMovePos = new Vector3(0f, Mathf.Sqrt(3f) / 2 * GetComponent<SpriteRenderer>().sprite.rect.height / 100, 0f);
        xMovePos = new Vector3(GetComponent<SpriteRenderer>().sprite.rect.width / 100 / 2, 0f, 0f);

        Debug.Log(yMovePos);
        Debug.Log(xMovePos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {     
        startTouch = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log(startTouch);
        
    }

    public void OnMouseDrag()
    {
        
    }

    public void OnMouseUp()
    {
        endTouch = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log(endTouch);

        float xInterval = endTouch.x -  startTouch.x;
        float yInterval = endTouch.y - startTouch.y; 

        if (Mathf.Abs(yInterval) + Mathf.Abs(xInterval) < 1f)
            return;

        if (Mathf.Abs(xInterval) < Mathf.Abs(yInterval))
        {
            if (startTouch.y > endTouch.y) //아래로
            {  
                if (transform.rotation.x / 360 != 0f)
                    return;

                transform.position -= yMovePos;
            }

            else //위로
            {
                if (transform.rotation.x / 360 == 0f)
                    return;

                transform.position += yMovePos;
            }
        }
        else // X축 이동
        {
            if (startTouch.x > endTouch.x) //왼쪽으로 
                transform.position -= xMovePos;  
            
            else //오른쪽으로
                transform.position += xMovePos;        
        }

        transform.Rotate(rotateValue); //rotate 변경은 항상 일정하므로
        rotateValue *= -1;
    }
}
