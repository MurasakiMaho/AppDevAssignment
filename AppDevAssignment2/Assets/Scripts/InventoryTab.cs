using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryTab : MonoBehaviour
{
    public GameObject tab1, tab2, tab3;
    bool tab1on, tab2on, tab3on;
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
    }
    public void activateTab1()
    {

        tab1on = true;
        tab2on = false;
        tab3on = false;
    }
    public void activateTab2()
    {
        if (tab1 == true || tab2 == true || tab3 == true)
        {
            tab1on = false;
            tab2on = true;
            tab3on = false;
        }
    }
    public void activateTab3()
    {
        if (tab1 == true || tab2 == true || tab3 == true)
        {
            tab1on = false;
            tab2on = false;
            tab3on = true;
        }
    }
    public void tabsOff()
    {
           tab1on = false;
           tab2on = false;
           tab3on = false;
    }
}
