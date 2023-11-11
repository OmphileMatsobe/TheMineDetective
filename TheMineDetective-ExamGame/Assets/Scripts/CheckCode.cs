using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckCode : MonoBehaviour
{
    [SerializeField]
    private List<int> Password;

    [SerializeField]
    private List<int> TypedPassword;


    [SerializeField]
    private int Dig1, Dig2, Dig3, Dig4;

    [SerializeField]
    private GameObject openDoor;

    [SerializeField]
    private bool CorrectCode;

    [SerializeField]
    private TextMeshProUGUI dig1, dig2, dig3, dig4;
    
    // Start is called before the first frame update
    void Start()
    {
        TypedPassword.Add(Dig1);
        TypedPassword.Add(Dig2);
        TypedPassword.Add(Dig3);
        TypedPassword.Add(Dig4);
    }

    // Update is called once per frame
    void Update()
    {
        dig1.text = Dig1.ToString();
        dig2.text = Dig2.ToString();
        dig3.text = Dig3.ToString();
        dig4.text = Dig4.ToString();




    }

    private void CheckCod()
    {
       
        for (int i = 0; i < TypedPassword.Count; i++)
        {
            if (Password[i] != TypedPassword[i])
            {
                Debug.Log("wrong");
                CorrectCode = false;
                return;
            }

            else
            {
                Debug.Log("correct");
                CorrectCode = true;
            }
           
            
        }

        if (CorrectCode == true)
        {
            openDoor.SetActive(false);
        }
    }

    public void Increasedig1()
    {
        Dig1 += 1;

        if (Dig1 > 9)
        {
            Dig1 = 0;
        }
        TypedPassword[0] = Dig1;
        CheckCod();

        
    }

    public void Decreasedig1()
    {
        Dig1 -= 1;

        if (Dig1 < 0)
        {
            Dig1 = 9;
        }


        TypedPassword[0] = Dig1;
        CheckCod();
        
    }

    public void Increasedig2()
    {
        Dig2 += 1;

        if (Dig2 > 9)
        {
            Dig2 = 0;
        }

        TypedPassword[1] = Dig2;
        CheckCod();
       
    }

    public void Decreasedig2()
    {
        Dig2 -= 1;

        if (Dig2 < 0)
        {
            Dig2 = 9;
        }

        TypedPassword[1] = Dig2;
        CheckCod();
        
    }

    public void Increasedig3()
    {
        Dig3 += 1;

        if (Dig3 > 9)
        {
            Dig3 = 0;
        }
        TypedPassword[2] = Dig3;
        CheckCod();
        
    }

    public void Decreasedig3()
    {
        Dig3 -= 1;

        if (Dig3 < 0)
        {
            Dig3 = 9;
        }

        TypedPassword[2] = Dig3;
        CheckCod();
        
    }

    public void Increasedig4()
    {
        Dig4 += 1;

        if (Dig4 > 9)
        {
            Dig4 = 0;
        }
        TypedPassword[3] = Dig4;
        CheckCod();
        
    }

    public void Decreasedig4()
    {
        Dig4 -= 1;

        if (Dig4 < 0)
        {
            Dig4 = 9;
        }

        TypedPassword[3] = Dig4;
        CheckCod();
       
    }
}
