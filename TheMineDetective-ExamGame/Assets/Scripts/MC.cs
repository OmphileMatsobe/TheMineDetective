using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC : MonoBehaviour
{

    [SerializeField]
    Renderer renderer;
    
    
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(renderer.isVisible);
            
        }
    }
}
