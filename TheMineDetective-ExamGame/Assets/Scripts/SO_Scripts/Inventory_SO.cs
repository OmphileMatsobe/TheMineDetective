using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



[Serializable]
[CreateAssetMenu(menuName = "SOFolder/InventorySO")]
public class Inventory_SO : ScriptableObject
{
    [SerializeField]
    public List<ScriptableObject> ItemsInInventory;
}
