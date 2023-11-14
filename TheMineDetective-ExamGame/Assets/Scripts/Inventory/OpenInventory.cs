using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    [SerializeField]
    private GameObject inventory;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            displayInventory();
            Debug.Log("Fok");
        }
    }

    private void displayInventory()
    {
        Debug.Log(inventory.activeSelf);
        if (inventory.activeSelf == false)
        {


            Debug.Log("pressed");
            inventory.SetActive(true);


            inventory.GetComponent<UpdateInventory>().ApplyInventory();


            
        }

        else 
        {
            inventory.GetComponent<UpdateInventory>().CloseInventory();

            inventory.SetActive(false);

        }
    }

    private void Awake()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory");
    }
}
