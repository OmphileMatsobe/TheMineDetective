using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLens : MonoBehaviour
{

    Vector2 clampedPosition, spawn;
    Vector2 posDif = Vector2.zero;

    private void Start()
    {
        clampedPosition = spawn = transform.position;
    }
    private void OnMouseDown()
    {
        posDif = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
        Debug.Log("Hello");
    }

    public void OnMouseDrag()
    {
        clampedPosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - posDif;
        transform.position = clampedPosition;
    }

    public void Update()
    {

    }
}
