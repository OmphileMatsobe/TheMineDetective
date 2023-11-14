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
      for (int i = 0; i < Inventory_SO.ItemsInInventory.Count; i++)
        {
            Inventory_SO.ItemsInInventory[i].item = transform.GetChild(i).gameObject.GetComponent<InventoryInfo>().item.item;
            Debug.Log(Inventory_SO.ItemsInInventory[i].item);
        }
    }

    private void Awake()
    {
        Inventory_SO = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<TestInventory>().inventory_SO;
    }
}
