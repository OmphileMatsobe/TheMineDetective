using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "SOFolder/Items")]
public class Items_SO :ScriptableObject
{
    [SerializeField]
    private Items item;

    [SerializeField]
    public bool InteractableSO = false;

    public enum Items
    {
        KeyDesk,
        Notebook,
        Gun,
        Flashlight,
        DetectiveKit
    }
}
