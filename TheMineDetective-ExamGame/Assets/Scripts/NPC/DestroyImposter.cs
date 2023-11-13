using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyImposter : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Imposter"))
        {
            Destroy(collision.gameObject);
            Debug.Log("check");
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Imposter"))
        {
            Destroy(collision.gameObject);
            Debug.Log("check");
        }
    }
}
