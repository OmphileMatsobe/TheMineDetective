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
    [SerializeField]
    GameObject puzzle;

    GearPuzzleManager manager;

    Vector2 clampedPosition, spawn;
    Vector2 posDif = Vector2.zero;

    private void Start()
    {
        puzzle = GameObject.FindWithTag("GearPuzzle");
        clampedPosition = spawn = transform.position;
        manager = puzzle.GetComponent<GearPuzzleManager>();
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
            manager.count++;
            transform.position = circleMain.transform.position;
        }
    }

    public void Update()
    {
        if (manager.count == 9)
        {
            transform.Rotate(new Vector3(0, 0, direction * 90 * Time.deltaTime));
        }
    }
}
