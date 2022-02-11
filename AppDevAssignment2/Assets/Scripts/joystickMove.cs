using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class JoystickMove : MonoBehaviour
{
    public GameObject joystick;//joystick thumb
    public GameObject joystickBG;//joystick background
    public Vector2 joystickVec;//movement of the joystick to control player movement
    private Vector2 joystickTouchPos;//location the player touches
    private Vector2 joystickOriginalPos;//original position of joystick
    private float joystickRadius;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        joystickOriginalPos = joystickBG.transform.position;
        joystickRadius = joystickBG.GetComponent<RectTransform>().sizeDelta.y / 2;
    }

    public void PointerDown()
    {
        joystickTouchPos = Input.mousePosition;
        joystick.transform.position = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    public void Drag(BaseEventData baseEventData)
    {
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector2 dragPos = pointerEventData.position;
        joystickVec = (dragPos - joystickTouchPos).normalized;

        float joystickDist = Vector2.Distance(dragPos, joystickTouchPos);
        Vector2 transform = cam.ScreenToWorldPoint(joystickTouchPos);
        if (joystickDist < joystickRadius)
        {
            joystick.transform.position = transform + joystickVec * joystickDist;
        }
        else
        {
            joystick.transform.position = transform + joystickVec * joystickRadius;
        }
    }

    public void PointerUp()
    {
        joystickVec = Vector2.zero;
        joystick.transform.position = joystickOriginalPos;
        joystickBG.transform.position = joystickOriginalPos;
    }

}
