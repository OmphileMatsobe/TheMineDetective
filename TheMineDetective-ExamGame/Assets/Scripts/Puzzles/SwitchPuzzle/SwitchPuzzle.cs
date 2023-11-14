using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;

public class SwitchPuzzle : MonoBehaviour
{


    bool allDown, allUp, switchSet;
    public int firstGo = 0;
    int flag = 1;
    int cal;
    Switches switches;
    bool flagBool = false;

    public int switchOne, switchTwo, switchThree, switchFour, switchFive;

    List<int> RandomNum = new List<int>();
    enum state
    {
        one = 1,
        two = 2,
        three = 3,
        four = 4,
        five = 5,
    }

    private void Start()
    {
        cal = Random.Range(1, 5);
        calibrate(cal);
    }

    void calibrate(int cal)
    {
        if (cal == 1)
        {
            switchOne = 3;
            switchTwo = 5;
            switchThree = 2;
            switchFour = 4;
            switchFive = 1;
        }
        else if (cal == 2)
        {
            switchOne = 1;
            switchTwo = 2;
            switchThree = 5;
            switchFour = 4;
            switchFive = 3;
        }
        else if (cal == 3)
        {
            switchOne = 5;
            switchTwo = 1;
            switchThree = 4;
            switchFour = 3;
            switchFive = 2;
        }
        else if (cal == 4)
        {
            switchOne = 4;
            switchTwo = 3;
            switchThree = 1;
            switchFour = 5;
            switchFive = 2;
        }
        else
        {
            switchOne = 1;
            switchTwo = 3;
            switchThree = 2;
            switchFour = 5;
            switchFive = 4;
        }
    }
    
    // Update is called once per frame
    void Update()
    {

    }
   
}
