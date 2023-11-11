using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class HintManager : MonoBehaviour
{
   [SerializeField]
    Notebook notebook;


    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Prototype")
        {
            notebook.Hints.Clear();
        }
    }



    public void AddHint(Hints_SO add_hint)
    {
        notebook.Hints.Add(add_hint);
        
    }

}
