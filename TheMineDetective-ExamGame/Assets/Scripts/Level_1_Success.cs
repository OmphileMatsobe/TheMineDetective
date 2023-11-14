using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Level_1_Success : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private List<Items_SO> RequiredItems;


    [SerializeField]
    private bool levelDone = false;

    [SerializeField]
    private TestInventory testInventory;

    [SerializeField]
    private int checkamount = 0;

    [SerializeField]
    private bool AllItems = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        CheckItems();

        NextScene();
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

    private void NextScene()
    {
        if (AllItems == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("PP");
        }

        else
        {
            checkamount = 0;
        }
       
    }

   private void CheckItems()
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

                    if (checkamount == RequiredItems.Count)
                    {
                        AllItems = true;

                        return;
                    }

                    else
                    {
                        AllItems = false;
                        Debug.Log("Nee");
                    }

                }
            }


        }
    }

}
