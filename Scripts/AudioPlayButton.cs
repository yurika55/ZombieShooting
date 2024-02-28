using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayButton : MonoBehaviour
{
    public GameObject audioObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void AudioPlay()
    {
        audioObject.GetComponent<AudioSource>().Play();
    }
}
