using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "SOFolder/Items")]
public class Items_SO :ScriptableObject
{
    [SerializeField]
    public Items item;

    [SerializeField]
    public bool InteractableSO = true;

    [SerializeField]
    public Image image;

    public enum Items
    {
        KeyDesk,
        Notebook,
        Gun,
        Flashlight,
        DetectiveKit,
        MugEmpty,
        Laxatives,
        Fuse,
        MugFull
        
    }
}
