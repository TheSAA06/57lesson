using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldController : MonoBehaviour
{
    AudioSource audio;
    MeshRenderer display;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        display = GetComponent<MeshRenderer>();
        audio.Stop();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        audio.Play();
        display.enabled = false;
    }
}
