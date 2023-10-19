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

    // Start is called before the first frame update
    void Start()
    {
        moveTo.interactable = pickUp.interactable = takePic.interactable = false;
        note.interactable = putInBag.interactable = false;
    }

    public void onClickButton(Image imgSet)
    {
        Debug.Log("Activating");
        setImage = imgSet;
        display.SetActive(true);
        moveTo.interactable = true;
    }

    public void onClickClose()
    {
        display.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        display.SetActive(false);
        
    }
}
