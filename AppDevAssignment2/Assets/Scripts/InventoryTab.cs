using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryTab : MonoBehaviour
{
    public GameObject tab1, tab2, tab3, tab4;
    bool tab1on, tab2on, tab3on, tab4on;
    // Start is called before the first frame update
    void Start()
    {
        tabsOff();
    }

    // Update is called once per frame
    void Update()
    {
        if (tab1on == true)
            tab1.gameObject.SetActive(true);
        else
            tab1.gameObject.SetActive(false);
        if (tab2on == true)
            tab2.gameObject.SetActive(true);
        else
            tab2.gameObject.SetActive(false);
        if (tab3on == true)
            tab3.gameObject.SetActive(true);
        else
            tab3.gameObject.SetActive(false);
        if (tab4on == true)
            tab4.gameObject.SetActive(true);
        else
            tab4.gameObject.SetActive(false);
    }
    public void activateTab1()
    {
        tab1on = true;
        tab2on = false;
        tab3on = false;
        tab4on = false;
    }
    public void activateTab2()
    {
        tab1on = false;
        tab2on = true;
        tab3on = false;
        tab4on = false;
    }
    public void activateTab3()
    {
        tab1on = false;
        tab2on = false;
        tab3on = true;
        tab4on = false;
    }
    public void activateTab4()
    {
        tab1on = false;
        tab2on = false;
        tab3on = false;
        tab4on = true;
    }
    public void tabsOff()
    {
        tab1on = false;
        tab2on = false;
        tab3on = false;
        tab4on = false;
    }
}
