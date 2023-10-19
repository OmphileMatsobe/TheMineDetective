using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class PickUpObjects : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private TestInventory testInventory;

    [SerializeField]
    public Items_SO item;

    public void OnPointerClick(PointerEventData eventData)
    {
        // throw new NotImplementedException();

      if (item.InteractableSO == true)
        {
            Debug.Log(item.name);

            testInventory.inventory_SO.ItemsInInventory.Add(item);

            Destroy(gameObject);
        }
        
       

    }


    // Start is called before the first frame update
    void Start()
    {
        testInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<TestInventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
