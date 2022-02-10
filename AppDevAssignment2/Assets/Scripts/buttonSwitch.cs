using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonSwitch : MonoBehaviour
{
    private void Start()
    {
        a.interactable = false;
        b.interactable = false;
        c.interactable = false;
        d.interactable = false;
    }
    public Button a, b, c, d;
    // Start is called before the first frame update
    public void switchA(bool clickable)
    {
        if (a == clickable)
            a.interactable = true;
        else
            a.interactable = false;
    }
    public void switchB(bool clickable)
    {
        if (b == clickable)
            b.interactable = true;
        else
            b.interactable = false;
    }
    public void switchC(bool clickable)
    {
        if (c == clickable)
            c.interactable = true;
        else
            c.interactable = false;
    }
    public void switchD(bool clickable)
    {
        if (d == clickable)
            d.interactable = true;
        else
            d.interactable = false;
    }
}
