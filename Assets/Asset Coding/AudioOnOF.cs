using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnOf : MonoBehaviour
{
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AudioOn()
    {
        audio.Play();
    }
    public void AudioOf()
    {
        audio.Stop();
    }
}
