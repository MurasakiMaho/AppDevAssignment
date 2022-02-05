using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class TouchCTRL : MonoBehaviour
{
    public Text printout;
    private Image ImgFG;
    private Image ImgBG;

    // Start is called before the first frame update
    void Start()
    {
        ImgBG = GetComponent<Image>();
        ImgFG = transform.GetChild(0).GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        Touch tch;
        Vector3 wrldpoint;
        bool hit = false;

        if (Input.touchCount == 1)
        {
            tch = Input.GetTouch(0);
            wrldpoint = Camera.main.ScreenToWorldPoint(tch.position);
            wrldpoint.z = -1f;
            if (tch.phase == TouchPhase.Began)
            {
                if (Physics.Raycast(wrldpoint, Vector3.forward))
                {
                    hit = true;                
                }
            }
            else if (hit && (tch.phase == TouchPhase.Moved))
            {
                wrldpoint.z = 0f;
                ImgFG.transform.position = wrldpoint;
            }
            else if (tch.phase == TouchPhase.Ended)
            {
                hit = false;
            }
        }
        else if (Input.touchCount == 3)
        {
            SceneManager.LoadScene("Gameplay");
        }
        else if (Input.touchCount == 4)
        {
            SceneManager.LoadScene("Battle");
        }
    }

    public void Dragging()
    {
        #if UNITY_ANDROID
                Touch myTouch = Input.GetTouch(0);
                Vector3 newpos = new Vector3(myTouch.position.x, myTouch.position.y, 1);
        #else
        Vector3 newpos = new Vector3(Input.mouseposition.x, Input.mouseposition.y, 1);
        #endif

        ImgFG.rectTransform.position = newpos;
        printout.text = "x: " + myTouch.position.x + "y: " + myTouch.position.y;
    }

    public void ReturnOrigin()
    {
        ImgFG.rectTransform.anchoredPosition = new Vector3(0, 0, 1);
    }
}
