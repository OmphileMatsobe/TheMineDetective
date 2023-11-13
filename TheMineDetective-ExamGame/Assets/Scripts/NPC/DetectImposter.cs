using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectImposter : MonoBehaviour
{

    [SerializeField]
    private bool INTIMADATION;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Imposter"))
        {
            Debug.Log("Silence");
            INTIMADATION = true;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Imposter"))
        {
            Debug.Log("CanSpeak");
            INTIMADATION = false;
        }
    }
}
