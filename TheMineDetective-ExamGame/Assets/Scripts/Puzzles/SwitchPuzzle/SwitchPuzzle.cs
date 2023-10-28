using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPuzzle : MonoBehaviour
{
    // Start is called before the first frame update

    bool allDown, allUp, switchSet;
    public int firstGo = 0;
    int flag = 1;
    int switchComb;
    Switches switches;

    enum state
    {
        one = 1,
        two = 2,
        three = 3,
        four = 4,
        five = 5,

    }
    void Start()
    {
        calibarate();   
    }

    void calibarate()
    {
    }


    // Update is called once per frame
    void Update()
    {
        if (allDown == true)
        {
            flag = 0;
            switchSet = true;
        }

        if (allUp == true)
            flag = 2;
    }
}
