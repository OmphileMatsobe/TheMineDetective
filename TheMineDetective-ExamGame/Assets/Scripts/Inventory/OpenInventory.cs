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
        }
    }

    private void displayInventory()
    {
        if (inventory.activeSelf == true)
        {

            inventory.GetComponent<UpdateInventory>().CloseInventory();

            inventory.SetActive(false);
        }

        else if (inventory.activeSelf == false)
        {
            inventory.SetActive(true);
            
            
            inventory.GetComponent<UpdateInventory>().ApplyInventory();
        }
    }

    private void Awake()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory");
    }
}
