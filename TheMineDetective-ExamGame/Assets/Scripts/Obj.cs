using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obj : MonoBehaviour
{
    [SerializeField]
    GameManager gameManager;

    [SerializeField]
    Image img;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        gameManager.onClickButton(img, gameObject.tag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
