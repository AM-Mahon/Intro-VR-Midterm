using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CompletionCheck : MonoBehaviour
{
    private bool passed = false;   
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
            if(!passed){
                audioSource.Play ();
                passed = true;
            }
        
        }
        else{
            render.material.color = Color.red;
        }
    }
}
