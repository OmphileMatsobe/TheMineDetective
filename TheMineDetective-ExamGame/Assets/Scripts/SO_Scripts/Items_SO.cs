using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "SOFolder/Items")]
public class Items_SO :ScriptableObject
{
    [SerializeField]
    public Items item;

    [SerializeField]
    public bool InteractableSO = true;

    public enum Items
    {
        KeyDesk,
        Notebook,
        Gun,
        Flashlight,
        DetectiveKit
    }
}
