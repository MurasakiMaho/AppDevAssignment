using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeTransparency : MonoBehaviour
{
    public Image pic;
    public bool isTrans;

    // Start is called before the first frame update
    void Start()
    {
        if (isTrans == true)
            pic.enabled = false;
        else
            pic.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void clickEffect()
    {
        if (isTrans == true)
        {
            isTrans = false;
            pic.enabled = true;
        }
        else 
        {
            isTrans = true;
            pic.enabled = false;
        }
    }
}
