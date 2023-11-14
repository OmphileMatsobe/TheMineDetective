using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circles : MonoBehaviour
{
    [SerializeField]
    GameObject gear;

    public bool withinBound = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == gear)
        {
            withinBound = true;
            Debug.Log("is withinBound");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == gear)
        {
            withinBound = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
