using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show : MonoBehaviour
{
    public GameObject InfoObject;
    //private bool showhide = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowOb()
    {
        InfoObject.SetActive(true);
    }
    public void HideOb()
    {
        InfoObject.SetActive(false);
    }
}
