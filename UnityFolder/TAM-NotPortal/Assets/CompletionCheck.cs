using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//#include "DetectCollision.cs"
//<include file='DetectCollision.cs'/>
public class CompletionCheck : MonoBehaviour
{
    
    AudioSource audioSource;
    public DetectCollision toCheck;
    public DetectCollision toCheck2;
    
    MeshRenderer render;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource> ();
        render = this.GetComponent<MeshRenderer>();
        render.material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if(toCheck.get_collided() && toCheck2.get_collided()){
            render.material.color = Color.green;
        audioSource.Play ();
        }
        else{
            render.material.color = Color.red;
        }
    }
}
