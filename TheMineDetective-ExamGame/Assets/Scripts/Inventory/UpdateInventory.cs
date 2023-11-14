using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateInventory : MonoBehaviour
{

    [SerializeField]
    private Inventory_SO Inventory_SO;
   

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void Awake()
    {
        Inventory_SO = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<TestInventory>().inventory_SO;
    }


    public void ApplyInventory()
    {
       if (Inventory_SO.ItemsInInventory.Count > 0)
        {
            for (int i = 0; i < Inventory_SO.ItemsInInventory.Count; i++)
            {
                Transform child = transform.GetChild(i);
                child.gameObject.SetActive(true);
                child.gameObject.GetComponent<InventoryInfo>().Item = Inventory_SO.ItemsInInventory[i];
            }
        }
    }


    public void CloseInventory()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.gameObject.SetActive(false);
        }
    }
}
