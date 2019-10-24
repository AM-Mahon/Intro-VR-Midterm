using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Useful: https://docs.unity3d.com/Manual/CollidersOverview.html
    int collided;
    // Start is called before the first frame update
    MeshRenderer render;
    void Start()
    {
        render = this.GetComponent<MeshRenderer>();
        render.material.color = Color.red;
        collided = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool get_collided(){
        return collided>0;
    }

    void OnTriggerEnter(Collider other){
        //MeshRender 
        if(other.gameObject.tag == "box"){
            render.material.color = Color.green;
            collided++;
        }
    }

    void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "box"){
            collided--;
            if(collided = 0){
                render.material.color = Color.red;
            }
        }
        
    }
}
