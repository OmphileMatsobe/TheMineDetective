using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "SOFolder/Notebook")]
public class Notebook : ScriptableObject
{
    [SerializeField]
    public List<Hints_SO> Hints;
}
