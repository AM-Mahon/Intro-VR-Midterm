using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
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

    void OnTriggerEnter(Collider other){
        //MeshRender 
        render.material.color = Color.green;
    }

    void OnTriggerExit(Collider other){
        render.material.color = Color.red;
    }
}
