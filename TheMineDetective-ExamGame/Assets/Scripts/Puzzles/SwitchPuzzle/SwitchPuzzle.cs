using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPuzzle : MonoBehaviour
{
    // Start is called before the first frame update

    bool allDown, allUp, switchSet;
    public int firstGo = 0;
    int flag = 1;
    enum state
    {
        one = 1,
        two = 2,
        three = 3,
        four = 4,

    }
    void Start()
    {
        calibarate();
        allUp = allDown = switchSet = false;   
    }

    void calibarate()
    {
        firstGo = Random.Range(1, 4);
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
