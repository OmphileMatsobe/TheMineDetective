using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMagnifyingGlass : MonoBehaviour
{

    private Vector2 Mousepos;
    private Vector2 dragOffset;


    private void OnMouseDown()
    {
        dragOffset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    }
    // Update is called once per frame
    private void OnMouseDrag()
    {
        Mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Mousepos - dragOffset;
    }
}
