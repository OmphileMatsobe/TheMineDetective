using UnityEngine;
using UnityEngine.EventSystems;

public class SwitchHandle : MonoBehaviour
{
    [SerializeField]
    GameObject handleStick;
    [SerializeField]
    GameObject handleCenter;

    Vector2 clampedPosition, move, clamp, stickScale;
    Vector2 clampScale, clampStick, moveStick;
    Vector2 posDif = Vector2.zero;

    private void Start()
    {
        clampedPosition = transform.position;
        clamp = transform.position;
        stickScale = transform.localScale;
        clampScale = transform.localScale;
        clampStick = handleCenter.transform.position;

        changeStick();

    }
    private void OnMouseDown()
    {
        posDif = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }

    public void OnMouseDrag()
    {
        move = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - posDif;
        clampedPosition.y = Mathf.Clamp(move.y, -clamp.y, clamp.y);
        transform.position = clampedPosition;
    }

    private void changeStick()
    {
        moveStick = handleCenter.transform.position;
        moveStick.y = Mathf.Clamp(handleCenter.transform.position.y, -clampStick.y / 2, clampStick.y / 2);
        handleStick.transform.position = moveStick;
        stickScale.y = Mathf.Clamp(clampedPosition.y / 5, -clampScale.y, clampScale.y);
        handleStick.transform.localScale = stickScale;
    }

    public void Update()
    {
        changeStick();
    }
}