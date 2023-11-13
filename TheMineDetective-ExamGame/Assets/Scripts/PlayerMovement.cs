using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    GameManager gameManager;
    [SerializeField]
    float speed;
    Vector2 move, moveOnPress;
    float ver, hor;
    string tagCheck;
    bool setMove = false;

    // Start is called before the first frame update
    void Start()
    {
        move = transform.position;
        tagCheck = gameObject.tag;
        moveOnPress = transform.position;
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

        hor = Input.GetAxis("Horizontal");

        moveOnPress.x += hor * Time.deltaTime * speed; 

        transform.position = moveOnPress;
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
