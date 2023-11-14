using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzelManager : MonoBehaviour
{
    public int switchOnCount = 0, switchOrder;
    bool correctComb = false;

    SwitchPuzzle manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindWithTag("SwitchPuzzel").GetComponent<SwitchPuzzle>();
    }

    // Update is called once per frame
    void Update()
    {
        if (correctComb = false)
        {
            //AllLightsShouldBeOff
        }

        if(switchOnCount == 5)
        {
            Debug.Log("Puzzle Complete");
        }
    }
}
