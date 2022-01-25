using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintToScreen : MonoBehaviour
{
    public Text printout;
    // Start is called before the first frame update
    void Start()
    {
        printout.text = "Started";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickedButtA ()
    {
        printout.text = "Button A clicked!";
    }

    public void ClickedButtB()
    {
        printout.text = "Button B clicked!";
    }
}
