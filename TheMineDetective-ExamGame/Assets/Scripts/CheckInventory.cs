using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckInventory : MonoBehaviour, IPointerClickHandler
{

    [SerializeField]
    Items_SO.Items ItemNeeded;

    [SerializeField]
    TestInventory testInventory;

    [SerializeField]
    private int SetCamera;

    [SerializeField]
    CameraManager cameraManager;

    [SerializeField]
    Items_SO RemoveItem;
    

    public void OnPointerClick(PointerEventData eventData)
    {
        
        // throw new System.NotImplementedException();
       foreach (Items_SO inventory in testInventory.inventory_SO.ItemsInInventory)
        {
            if(inventory.item == ItemNeeded)
            {
                RemoveItem = inventory;
                cameraManager.ActiveCamera = SetCamera;
                cameraManager.ChangeCamera();
               
            }
        }

        testInventory.inventory_SO.ItemsInInventory.Remove(RemoveItem);
    }




    // Start is called before the first frame update
    void Start()
    {
        testInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<TestInventory>();
        cameraManager = GameObject.FindGameObjectWithTag("CameraManager").GetComponent<CameraManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
