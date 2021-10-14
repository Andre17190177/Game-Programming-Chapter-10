using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToMove : MonoBehaviour
{
    public float speed;
    Vector2 LastClickedPos;
    bool isMoving;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            isMoving = true;
        }

        if(isMoving && (Vector2)transform.position != LastClickedPos)
        {
            float move = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, LastClickedPos, move);
        }
        else
        {
            isMoving = false;
        }
    }
}
