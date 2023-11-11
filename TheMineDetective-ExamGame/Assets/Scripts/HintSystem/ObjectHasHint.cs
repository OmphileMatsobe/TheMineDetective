using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectHasHint : MonoBehaviour, IPointerClickHandler
{

    [SerializeField]
    Hints_SO TheHint;

    [SerializeField]
    HintManager hintManager;
    
    
    public void OnPointerClick(PointerEventData eventData)
    {
        hintManager.AddHint(TheHint);
        Debug.Log(TheHint.Hint);


        Destroy(this);
    }



    private void Start()
    {
        hintManager = GameObject.FindGameObjectWithTag("HintManager").GetComponent<HintManager>();
    }


}
