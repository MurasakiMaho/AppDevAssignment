using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Popup : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator animator;

    public void PopUp(string text)
    {
        popUpBox.SetActive(true);
        animator.SetTrigger("pop");
    }
}