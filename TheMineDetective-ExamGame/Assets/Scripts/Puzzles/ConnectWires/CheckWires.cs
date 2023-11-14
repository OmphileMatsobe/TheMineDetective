using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWires : MonoBehaviour
{

    [SerializeField]
    private int SwitchCount;
    private int OnCount = 0;

    [SerializeField]
    public bool Completed = false;
    
    public void ChangeCount(int points)
    {
        OnCount = OnCount + points;

        if (OnCount == SwitchCount)
        {
            Completed = true;
        }
    }
}
