using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    GameManager gameManager;
    Vector2 move;
    string tagCheck;
    bool setMove = false;

    // Start is called before the first frame update
    void Start()
    {
        move = transform.position;
        tagCheck = gameObject.tag;
    }

    public void activateMove(string obj)
    {
        setMove = true;
       tagCheck = obj;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = move;
    }

    private void FixedUpdate()
    {
        move = Vector2.MoveTowards(transform.position, GameObject.FindWithTag(tagCheck).transform.position, 0.1f);
        transform.position = move;

        if (setMove)
        {
            if (transform.position == GameObject.FindWithTag(tagCheck).transform.position)
            {
                gameManager.setDisplay();
                setMove = false;
            }
            
        }
    }
}
