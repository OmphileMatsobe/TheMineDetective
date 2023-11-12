using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DustBox"))
        {
            collision.GetComponent<SpriteMask>().enabled = true;
            Debug.Log("borsel");
        }
    }
}
