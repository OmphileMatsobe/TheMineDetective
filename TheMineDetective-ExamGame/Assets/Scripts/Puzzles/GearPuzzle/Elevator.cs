using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField]
    GameObject cnMach, Mine, game;
    [SerializeField]
    GameManager gameManager;

    private void OnMouseDown()
    {
        cnMach.SetActive(false);
        Mine.SetActive(false);
        game.GetComponent<GameManager>().enabled = false;
        
    }
}
