using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectImposter : MonoBehaviour
{

    [SerializeField]
    public bool INTIMADATION;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Imposter"))
        {
           
            INTIMADATION = true;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Imposter"))
        {
            
            INTIMADATION = false;
        }
    }
}
