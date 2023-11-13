using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NPC : MonoBehaviour, IPointerClickHandler    
{
    [SerializeField] GameObject dialog;

    public void OnPointerClick(PointerEventData eventData)
    {
       if (dialog.activeSelf == false)
        {
            dialog.SetActive(true);
        }

       else if (dialog.activeSelf == true)
        {
            dialog.SetActive(false);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
