using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lens : MonoBehaviour
{
    [SerializeField]
    private Transform Normalitem, ZoomedInItem;
  
    // Update is called once per frame
    void Update()
    {
        ZoomedInItem.position = Normalitem.position * 2 - transform.position;
    }
}
