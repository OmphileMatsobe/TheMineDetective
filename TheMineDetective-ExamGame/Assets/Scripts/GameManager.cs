using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Button moveTo, pickUp, takePic, note, putInBag;

    [SerializeField]
    Image setImage;

    [SerializeField]
    GameObject display;
    string prop;

    PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        moveTo.interactable = pickUp.interactable = takePic.interactable = false;
        note.interactable = putInBag.interactable = false;
        display.SetActive(false);
        prop = "Player";
        playerMovement = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }

    public void onClickButton(Image imgSet, string tag)
    {
        Debug.Log("Activating");
        setImage = imgSet;
        moveTo.interactable = true;

        prop = tag;
    }

    public void onClickClose()
    {
        display.SetActive(false);
    }

    public void onClickWalk() 
    {
        playerMovement.activateMove(prop);
        pickUp.interactable = takePic.interactable = true;
        note.interactable = putInBag.interactable = true;
    }

    public void setDisplay()
    {
        display.SetActive(true);
    }

    public void onClickPick()
    {
        if (prop != "Player")
        {
            Destroy(GameObject.FindWithTag(prop).GetComponent<PlayerMovement>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
