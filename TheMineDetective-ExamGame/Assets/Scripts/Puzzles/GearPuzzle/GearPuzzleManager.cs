using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GearPuzzleManager : MonoBehaviour
{

    public int count = 0, total;
    int flag = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator waitforseconds()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("puzzle complete");

        waitformore();
    }

    IEnumerator waitformore()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("Load scene");
        SceneManager.LoadScene(6);

    }
    // Update is called once per frame
    void Update()
    {
        if (count == total && flag == 0)
        {
            flag++;
            waitforseconds();
            
        }
    }
}
