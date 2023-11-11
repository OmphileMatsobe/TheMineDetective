using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "SOFolder/Hints")]
public class Hints_SO : ScriptableObject
{
    [SerializeField]
    [TextArea]
    public string Hint;
}
