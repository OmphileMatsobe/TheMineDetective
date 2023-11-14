using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField]
    GameObject cnMach, Mine, game,puzzle, cam;
    [SerializeField]
    GameManager gameManager;

    private void OnMouseDown()
    {
        cnMach.SetActive(false);

        cam.transform.position = new Vector3(0, 0, -9);

        puzzle.SetActive(true); 
        Mine.SetActive(false);
        game.GetComponent<GameManager>().enabled = false;
        
    }
}
