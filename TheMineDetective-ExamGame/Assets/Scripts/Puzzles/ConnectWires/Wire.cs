using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{

    Vector3 startPoint, startPos, newPos;


    [SerializeField]
    private SpriteRenderer WireEnd;

    [SerializeField]
    private GameObject LightOn;

    [SerializeField]
    public CheckWires checkWires;


    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.parent.position;
        startPos = transform.position;

    }

    public void OnMouseDrag()
    {
        newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPos.z = -10;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(newPos, .2f);

        foreach(Collider2D collider in colliders)
        {
            if (collider.gameObject != gameObject)
            {
                UpdateWire(collider.transform.position);

                if (transform.parent.name == collider.transform.parent.name)
                {

                    checkWires.ChangeCount(1);
                    
                    collider.GetComponent<Wire>()?.Done();
                    Done();
                }
                return;
            }
        }

        UpdateWire(newPos);
    }


    private void OnMouseUp()
    {
        UpdateWire(startPos);
    }

    void UpdateWire(Vector3 newPos)
    {
        transform.position = newPos;


        Vector3 direction = newPos - startPoint;
        transform.right = direction * transform.lossyScale.x;

        float dist = Vector2.Distance(startPoint, newPos);
        WireEnd.size = new Vector2(dist, WireEnd.size.y);
    }


    public void Done()
    {
        LightOn.SetActive(true);

        Destroy(this);
    }
}
