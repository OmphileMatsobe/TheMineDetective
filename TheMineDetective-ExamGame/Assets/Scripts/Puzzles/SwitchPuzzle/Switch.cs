using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField]
    GameManager gameManager;
    [SerializeField]
    GameObject cineMach;
    [SerializeField]
    GameObject mine, puzzle, game, cam;

    private void OnMouseDown()
    {
        puzzle.SetActive(true);
        
        gameManager = game.GetComponent<GameManager>();
        cineMach.SetActive(false);
        gameObject.SetActive(false);
        cam.transform.position = new Vector3 (0,0,-10);
        mine.SetActive(false);
    }
}
