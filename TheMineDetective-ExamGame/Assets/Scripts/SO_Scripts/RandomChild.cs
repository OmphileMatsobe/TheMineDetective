using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomChild : MonoBehaviour
{
    private void Awake()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            int NewSpot = Random.Range(0, transform.childCount);
            Vector3 temp = transform.GetChild(i).position;
            transform.GetChild(i).position = transform.GetChild(NewSpot).position;
            transform.GetChild(NewSpot).position = temp;
        }
    }
}
