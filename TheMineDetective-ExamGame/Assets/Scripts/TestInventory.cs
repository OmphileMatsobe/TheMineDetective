using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInventory : MonoBehaviour
{
    [SerializeField]
    public Inventory_SO inventory_SO;

   

    private void Update()
    {
        
    }

    private void Start()
    {
        int Count = inventory_SO.ItemsInInventory.Count;


        for (int i =  0; i < Count; i++)
        {
            inventory_SO.ItemsInInventory.Remove(inventory_SO.ItemsInInventory[0]);
        }
        
    }
}
