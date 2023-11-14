using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MinerNPC : MonoBehaviour, IPointerClickHandler
{

    DetectImposter detectImposter;
    CheckWires checkWires;


    public void OnPointerClick(PointerEventData eventData)
    {
        if (detectImposter.INTIMADATION == true)
        {
            //dialogue if imposter is still there
        }

        else if (detectImposter.INTIMADATION == false &&
           checkWires.Completed == false)
        {
            //dialogue if imposter is away but wires arent done
        }

        else if (detectImposter.INTIMADATION == false &&
            checkWires.Completed == true)
        {
            //dialogue if imposter is away and wires are done

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        detectImposter = GameObject.FindGameObjectWithTag("DetectImposter").GetComponent<DetectImposter>();
        checkWires = GameObject.FindGameObjectWithTag("WireManager").GetComponent<CheckWires>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
