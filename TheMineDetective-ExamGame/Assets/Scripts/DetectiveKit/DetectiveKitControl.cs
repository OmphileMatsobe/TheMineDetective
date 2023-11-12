using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectiveKitControl : MonoBehaviour
{

    [SerializeField]
    private GameObject PrefabUV, PrefabMG, PrefabFB;

    [SerializeField]
    private KeyCode PressUV, PressMG, PressFB;


    [SerializeField]
    private CameraManager cameraManager;


    private void Start()
    {
        cameraManager = GameObject.FindGameObjectWithTag("CameraManager").GetComponent<CameraManager>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(PressFB))
        {
            RetrieveTool(PrefabFB);
        }

        if (Input.GetKeyDown(PressUV))
        {
            RetrieveTool(PrefabUV);
        }

        if (Input.GetKeyDown(PressMG))
        {
            RetrieveTool(PrefabMG);
        }
    }


    private void RetrieveTool(GameObject equipment)
    {
     if ( GameObject.FindGameObjectWithTag("Equipment")== false)
        {
            Instantiate(equipment, cameraManager.Cameras[cameraManager.ActiveCamera].transform);
            equipment.transform.position = new Vector3(0, 0, 50f);
            // equipment.transform.position = new Vector3(transform.position.x, transform.position.y, 50f);
        }
     else if (GameObject.FindGameObjectWithTag("Equipment") == true)
        {
            Destroy(GameObject.FindGameObjectWithTag("Equipment"));
        }




    }

}
