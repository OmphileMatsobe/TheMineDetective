using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSwitching : MonoBehaviour
{
    PuzzelManager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindWithTag("SwitchPuzzel").GetComponent<PuzzelManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SwitchHandle") 
        {
            manager.switchOnCount++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "handle")
        {
            manager.switchOnCount--;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
