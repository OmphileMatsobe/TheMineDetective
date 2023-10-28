using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnGrapSwitch : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] GameObject switchHandle;
    [SerializeField] GameObject switcher;
    [SerializeField] GameObject OnSnap, OffSnap;
    Switches switches;

    [SerializeField] Camera pointer;


    enum side
    {
        on,
        off,
    }

    private enum dragHandle
    {
        notOnDrag,
        startDrag,
        OnDrag,
    }

    private dragHandle handleDrag;

    public void OnBeginDrag(PointerEventData eventData)
    {
        MoveHandle(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        MoveHandle(eventData);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        MoveHandle(eventData);
    }

    private void MoveHandle(PointerEventData eventData)
    {
        var screenPos = eventData.position;
        var worldPos = pointer.ScreenToWorldPoint(screenPos);

        switchHandle.transform.position = worldPos;
    }


    // Start is called before the first frame update
    void Start()
    {
        //Make Sure Everthing is on Off

        switchHandle.transform.position = OffSnap.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Handle")
        {
            RecordSide();
        }
    }

    void RecordSide()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
