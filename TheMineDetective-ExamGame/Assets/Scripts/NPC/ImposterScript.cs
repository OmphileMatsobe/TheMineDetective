using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ImposterScript : MonoBehaviour, IPointerClickHandler
{


    [SerializeField]
    private Items_SO RequiredItem;

    TestInventory testInventory;

    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private float moveSpeed;


    public void OnPointerClick(PointerEventData eventData)
    {
       foreach (Items_SO inventory in testInventory.inventory_SO.ItemsInInventory)
        {
            if (inventory.item == RequiredItem.item)
            {
                testInventory.inventory_SO.ItemsInInventory.Remove(inventory);

                //Dialogue when handing laxatives
                MoveImposter();

            }

            else if (inventory.item != RequiredItem.item) 
            {
                Debug.Log("Fok of");
            }
        }
    }

    private void MoveImposter()
    {
        rb.velocity = new Vector2(-1 * moveSpeed, rb.velocity.y);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        testInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<TestInventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
