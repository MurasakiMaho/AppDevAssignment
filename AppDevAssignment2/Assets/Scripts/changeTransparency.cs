using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeTransparency : MonoBehaviour
{
    public Image pic;
    public bool transparent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void clickEffect()
    {
        var picAlpha = pic.color;
        if (transparent == true)
        {
            picAlpha.a = 1f;
        }
        else if (transparent == false)
        {
            picAlpha.a = 0f;
        }
        pic.color = picAlpha;
    }
    public void changeBool()
    {
        if (transparent == true)
            transparent = false;
        else
            transparent = true;
    }
}
