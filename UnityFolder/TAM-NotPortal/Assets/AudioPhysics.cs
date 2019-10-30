using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPhysics : MonoBehaviour
{

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    
    void OnCollisionEnter(Collision collision)
    {
        
            audioSource.Play();
        
    
    }
    // Update is called once per frame
    void Update()
    {
    
        
    }
}
