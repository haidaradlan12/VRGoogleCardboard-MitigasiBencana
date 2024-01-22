using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GvrButton : MonoBehaviour
{
    public Image imaCircle;
    public UnityEvent GvrClick;
    public float totaltime = 2;
    bool GvrStatus = false;
    public float GvrTimer;

    // Update is called once per frame
    void Update()
    {
        if (GvrStatus == true)
        {
            GvrTimer += Time.deltaTime;
            imaCircle.fillAmount = GvrTimer / totaltime;
            
        }
        if (GvrTimer > totaltime)
        {
            GvrClick.Invoke();
        }

    }
    public void GvrOn()
    {
        GvrStatus = true;
    }
    public void GvrOff()
    {
        GvrStatus = false;
        GvrTimer = 0;
        imaCircle.fillAmount = 0;
    }
}
