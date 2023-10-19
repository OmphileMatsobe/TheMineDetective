using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void activateMove(GameObject obj)
    {
       move = Vector2.MoveTowards(transform.position, obj.transform.position, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = move;
    }
}
