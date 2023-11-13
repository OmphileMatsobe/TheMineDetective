using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> Cameras;

    [SerializeField]
    public int ActiveCamera;

    [SerializeField]
    private Collider2D colPL;

    [SerializeField]
    Plane[] planes;
    
    // Start is called before the first frame update
    void Start()
    {
        colPL = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
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
        

        foreach (GameObject camera in Cameras)
        {
            planes = GeometryUtility.CalculateFrustumPlanes(camera.GetComponent<Camera>());
           
            if(GeometryUtility.TestPlanesAABB(planes, colPL.bounds))
            {
                ActiveCamera = Cameras.IndexOf(camera);
            }
            
            
            
            
            
            
            
            
            
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
