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

    [SerializeField]
    private bool unlocked = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (unlocked == false)
        {
            foreach (Items_SO inventory in testInventory.inventory_SO.ItemsInInventory)
            {
                if (inventory.item == ItemNeeded)
                {
                    RemoveItem = inventory;
                    cameraManager.ActiveCamera = SetCamera;
                    cameraManager.ChangeCamera();
                    unlocked = true;
                }
            }

            testInventory.inventory_SO.ItemsInInventory.Remove(RemoveItem);
        }

        else
        {
            cameraManager.ActiveCamera = SetCamera;
            cameraManager.ChangeCamera();
        }
      
       
    }




    // Start is called before the first frame update
    void Start()
    {
        testInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<TestInventory>();
        cameraManager = GameObject.FindGameObjectWithTag("CameraManager").GetComponent<CameraManager>();
    }

   
}
