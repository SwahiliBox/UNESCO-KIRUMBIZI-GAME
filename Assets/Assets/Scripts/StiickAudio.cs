using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StiickAudio : MonoBehaviour
{

    // Use this for initialization
    public AudioClip stickAudio;
    public AudioSource AudioSrc;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void stickSound()
    {
        AudioSrc.PlayOneShot(stickAudio);
    }
}
