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
        for (int i = 0; i < RequiredItems.Count; i++)
        {
            Debug.Log("fok");
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
                    }

                }
            }


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

    private void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
