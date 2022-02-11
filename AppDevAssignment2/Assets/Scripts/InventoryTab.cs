using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryTab : MonoBehaviour
{
    public GameObject tab1, tab2, tab3;
    // Start is called before the first frame update
    public void activateTab1()
    {

        tab1.gameObject.SetActive(true);
        tab2.gameObject.SetActive(false);
        tab3.gameObject.SetActive(false);
    }
    public void activateTab2()
    {
        tab1.gameObject.SetActive(false);
        tab2.gameObject.SetActive(true);
        tab3.gameObject.SetActive(false);
    }
    public void activateTab3()
    {
        tab1.gameObject.SetActive(false);
        tab2.gameObject.SetActive(false);
        tab3.gameObject.SetActive(true);
    }
}
