using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    bool collided;
    // Start is called before the first frame update
    MeshRenderer render;
    void Start()
    {
        render = this.GetComponent<MeshRenderer>();
        render.material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool get_collided(){
        return collided;
    }

    void OnTriggerEnter(Collider other){
        //MeshRender 
        render.material.color = Color.green;
        collided = true;
    }

    void OnTriggerExit(Collider other){
        render.material.color = Color.red;
        collided = false;
    }
}
