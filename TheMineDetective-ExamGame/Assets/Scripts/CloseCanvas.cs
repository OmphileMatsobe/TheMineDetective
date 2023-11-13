using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseCanvas : MonoBehaviour
{
    [SerializeField]
    private GameObject Checkcamera;

    [SerializeField]
    private GameObject closeCanvas;
       



    private void Update()
    {
        if (Checkcamera.activeSelf == false)
        {
            closeCanvas.SetActive(false);
        }
    }


  
}
