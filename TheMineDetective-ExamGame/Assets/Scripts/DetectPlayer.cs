using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> InteractableObjects;

   

    [SerializeField]
    private bool PlayerIsClose = false;

    
  
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Slaap");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void OnEnter2D(Collider2D collision)
    //{
       /* if (collision.tag == "Player")
        {
            foreach (GameObject objects in InteractableObjects)
            {
                if (objects.GetComponent<InteractableO>() == true)
                {
                    objects.GetComponent<InteractableO>().InteractableObj = true;
                }

                else if (objects.GetComponent<PickUpObjects>() == true)
                {
                    objects.GetComponent<PickUpObjects>().item.InteractableSO = true;
                }
            }

           

        }

        else
        {
            foreach (GameObject objects in InteractableObjects)
            {
                if (objects.GetComponent<InteractableO>() == true)
                {
                    objects.GetComponent<InteractableO>().InteractableObj = false;
                }

                else if (objects.GetComponent<PickUpObjects>() == true)
                {
                    objects.GetComponent<PickUpObjects>().item.InteractableSO = false;
                }
            }
               
        }



    } */

    private void OnTriggerEnter2D(Collider2D collision)
    {
       

        if (collision.tag == "Player")
        {
            foreach (GameObject objects in InteractableObjects)
            {
                if (objects.GetComponent<InteractableO>() == true)
                {
                    objects.GetComponent<InteractableO>().InteractableObj = true;
                }

                else if (objects.GetComponent<PickUpObjects>() == true)
                {
                    objects.GetComponent<PickUpObjects>().item.InteractableSO = true;
                }
            }



        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            foreach (GameObject objects in InteractableObjects)
            {
                if (objects.GetComponent<InteractableO>() == true)
                {
                    objects.GetComponent<InteractableO>().InteractableObj = false;
                }

                else if (objects.GetComponent<PickUpObjects>() == true)
                {
                    objects.GetComponent<PickUpObjects>().item.InteractableSO = false;
                }
            }
        }
    }

}
