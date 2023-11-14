using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class OnSwitching : MonoBehaviour
{
    PuzzelManager manager;
    public int ID;

    [SerializeField]
    GameObject light;

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
            if (manager.switchOnCount == ID)
            {
                light.GetComponent<Light2D>().color = Color.green;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SwitchHandle")
        {
            manager.switchOnCount--;
            light.GetComponent<Light2D>().color = Color.red;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
