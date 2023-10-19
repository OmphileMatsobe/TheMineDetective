using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> Cameras;

    [SerializeField]
    public int ActiveCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            MainView();
        }
    }

    public void ChangeCamera()
    {
        foreach (GameObject camera in Cameras)
        {
            if (Cameras.IndexOf(camera)== ActiveCamera)
            {
                camera.SetActive(true);
            }

            else
            {
                camera.SetActive(false);
            }
        }
    }


    public void MainView()
    {
        ActiveCamera = 0;

        foreach (GameObject camera in Cameras)
        {
            if (Cameras.IndexOf(camera) == ActiveCamera)
            {
                camera.SetActive(true);
            }

            else
            {
                camera.SetActive(false);
            }
        }
    }
}
