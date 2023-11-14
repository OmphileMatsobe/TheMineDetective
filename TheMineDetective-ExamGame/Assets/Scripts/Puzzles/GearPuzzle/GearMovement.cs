using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearMovement : MonoBehaviour
{
    [SerializeField]
    float direction;
    [SerializeField]
    Circles circle;
    [SerializeField]
    GameObject circleMain;

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

    private void OnMouseUp()
    {
        if (circle.withinBound == false)
        {
            transform.position = spawn;
        }
        else
        {
            transform.position = circleMain.transform.position;
        }
    }

    public void Update()
    {
        transform.Rotate(new Vector3(0, 0, direction * 90 * Time.deltaTime));
    }
}
