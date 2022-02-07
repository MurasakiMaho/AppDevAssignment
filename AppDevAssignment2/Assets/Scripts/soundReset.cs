using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Slider musicVol, SFXVol;
    public void resetValue()
    {
        musicVol.value = 0.531f;
        SFXVol.value = 0.395f;
    }
}
