using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestInventory : MonoBehaviour
{
    [SerializeField]
    public Inventory_SO inventory_SO;

   

    private void Update()
    {
        
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Prototype")
        {
            inventory_SO.ItemsInInventory.Clear();
        }
        
    }
}
