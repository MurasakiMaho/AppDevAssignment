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
        printout.text = "What can you do?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickedButt1 ()
    {
        printout.text = "You tried attacking!";
    }

    public void ClickedButt2()
    {
        printout.text = "You tried calling for help!";
    }

    public void ClickedButt3()
    {
        printout.text = "You tried using an item!";
    }

    public void ClickedButt4()
    {
        printout.text = "You tried running away!";
    }
}
