using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnGrapSwitch : MonoBehaviour
{
    [SerializeField] GameObject switchHandle;
    [SerializeField] GameObject OnSnap, OffSnap;

    // Start is called before the first frame update
    void Start()
    {
        //Make Sure Everthing is on Off

        switchHandle.transform.position = OffSnap.transform.position;
    }
}
