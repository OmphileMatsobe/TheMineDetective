using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ExchangeItems : MonoBehaviour,IPointerClickHandler
{
    [SerializeField]
    private Items_SO ReceivedItem;

    [SerializeField]
    private List<Items_SO> RequiredItems;

    [SerializeField]
    private List<Items_SO> RemoveItems;

    [SerializeField]
    private TestInventory testInventory;

    [SerializeField]
    private bool AllItems = false;

    [SerializeField]
    private int checkamount = 0;

    [SerializeField]
    private GameObject fullmug;

    [SerializeField]
    private Transform placement;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(RequiredItems.Count);

        CheckItems();

        ItemsExchange();

       
    }


    void Start()
    {
        testInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<TestInventory>();
       
    }

    void CheckItems()
    {
        for (int i = 0; i < RequiredItems.Count; i++)
        {
            
            foreach (Items_SO inventory in testInventory.inventory_SO.ItemsInInventory)
            {
                if (inventory.item != RequiredItems[i].item)
                {
                    AllItems = false;

                }

                else if (inventory.item == RequiredItems[i].item)
                {
                    checkamount += 1;
                    RemoveItems.Add(RequiredItems[i]);
                    if (checkamount == RequiredItems.Count)
                    {
                        AllItems = true;
                        return;
                    }

                    else
                    {
                        AllItems = false;
                    }

                }
            }


        }
    }

    void ItemsExchange()
    {
        if (AllItems == true)
        {


            Instantiate(fullmug, placement);


            for (int i = 0; i < RemoveItems.Count; i++)
            {
                testInventory.inventory_SO.ItemsInInventory.Remove(RemoveItems[i]);
            }
        }
    }

}
