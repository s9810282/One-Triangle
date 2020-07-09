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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {     
        startTouch = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(startTouch);
        
    }

    public void OnMouseDrag()
    {
        
    }

    public void OnMouseUp()
    {
        endTouch = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(endTouch);

        float xInterval = endTouch.x -  startTouch.x; //이동거리
        float yInterval = endTouch.y - startTouch.y;  //

        //마우스 이동거리가 1f가 넘지않을시 이동 X
        if (Mathf.Abs(yInterval) < 1f)
            return;

        if (Mathf.Abs(xInterval) < 1f)
            return;

        if (Mathf.Abs(xInterval) < Mathf.Abs(yInterval)) //Y축 이동
        {
            Vector3 temp = new Vector3(0f, Mathf.Sqrt(3f) / 2, 0f);

            if (startTouch.y > endTouch.y) //아래로
            {
                if (transform.rotation.x / 360f != 0f) //이미지 돌려져 있는 위치인가
                    return;

                transform.position -= temp;
            }

            else //위로
            {
                if (transform.rotation.x / 360f != 180f) //이미지 돌려져 있는 위치인가
                    return;

                transform.position += temp;
            }
        }
        else // X축 이동
        {
            Vector3 temp = new Vector3(0.5f, 0f, 0f);

            if (startTouch.x > endTouch.x) //왼쪽으로 
            {
                transform.position -= temp;  
            }
            else //오른쪽으로
            {
                transform.position += temp;
            }
        }

        transform.Rotate(rotateValue); //rotate 변경은 항상 일정하므로
        rotateValue *= -1;
    }
}
