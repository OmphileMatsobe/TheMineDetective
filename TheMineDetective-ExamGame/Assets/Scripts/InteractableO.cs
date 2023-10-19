using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class InteractableO : MonoBehaviour, IPointerClickHandler
{

    [SerializeField]
    CameraManager cameraManager;

    [SerializeField]
    private int SetCamera;

    [SerializeField]
    public bool InteractableObj = false;
    
    
    public void OnPointerClick(PointerEventData eventData)
    {
      
        if (InteractableObj == true)
        {
            cameraManager.ActiveCamera = SetCamera;

            cameraManager.ChangeCamera();
        }
        
        
        // throw new NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        cameraManager = GameObject.FindGameObjectWithTag("CameraManager").GetComponent<CameraManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
