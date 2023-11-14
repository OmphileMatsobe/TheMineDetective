using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;

public class SwitchPuzzle : MonoBehaviour
{
    // Start is called before the first frame update

    bool allDown, allUp, switchSet;
    public int firstGo = 0;
    int flag = 1;
    int switchComb, x, y, z, switchNum, count, itCount;
    Switches switches;
    bool flagBool = false;

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

        for (x = 0; x < 5; x++)
        {
            int a = 0;

            while (a == 0)
            {
                a = Random.Range(0, 5);
                if (!RandomNum.Contains(a))
                {
                    RandomNum.Add(a);
                }
                else
                {
                    a = 0;
                }
            }
        } 


        Debug.Log(RandomNum[0] + " " + RandomNum[1] + " " + RandomNum[2] + " " + RandomNum[3] + " " + RandomNum[4]);
    }
    
    // Update is called once per frame
    void Update()
    {

    }
   
}
