using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryInfo : MonoBehaviour
{
    [SerializeField]
    public Items_SO Item;

    [SerializeField]
    private Image Image;

    // Update is called once per frame
    void Update()
    {
        Image.sprite = Item.image;
    }


}
