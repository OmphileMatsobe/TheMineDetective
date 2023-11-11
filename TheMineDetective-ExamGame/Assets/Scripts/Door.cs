using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Door : MonoBehaviour, IPointerClickHandler
{

    [SerializeField]
    private GameObject ExitPosition;

    [SerializeField]
    private GameObject Player;

    Collider2D colPlayer, colExitPos;
    

    public void OnPointerClick(PointerEventData eventData)
    {
       if (gameObject.GetComponent<InteractableO>().InteractableObj == true)
        {
            Player.transform.position = ExitPosition.transform.position;
           
                        Debug.Log("move");
        }
    }

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").gameObject;
        colPlayer = Player.GetComponent<Collider2D>();
        colExitPos = ExitPosition.GetComponent<Collider2D>();
    }


}
