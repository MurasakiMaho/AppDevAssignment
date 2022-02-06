using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class joystickMove : MonoBehaviour
{
    private Image FG, BG;
    // Start is called before the first frame update
    void Start()
    {
        BG = GetComponent<Image>(); 
        FG = transform.GetChild(0).GetComponent<Image>();
    }

    public void Dragging()
    {
        Vector3 newPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        FG.rectTransform.position = newPos;
    }
    public void ReturnOrigin()
    {
        FG.rectTransform.anchoredPosition = new Vector3(0, 0, 1);
    }
}
