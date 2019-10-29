using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour
{
    private Collider grabbedGameObject;
    //GameObject hand = this.getComponent<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetButtonDown("Fire1")){
            if(grabbedGameObject != null){
                grabbedGameObject.transform.parent = transform;
                grabbedGameObject.GetComponent<Rigidbody>().isKinematic = true;
            }
            //buttonHeld = true;
        }

        if(Input.GetButtonUp("Fire1")){
            grabbedGameObject.transform.parent = null;
            grabbedGameObject.GetComponent<Rigidbody>().isKinematic = false;
        }   
    }

    void OnTriggerEnter(Collider other){
        //MeshRender 
        if(other.gameObject.tag == "box"){
            grabbedGameObject = other;
            // grabbedGameObject.transform.parent = hand.transform;
            // grabbedGameObject.getComponent<Rigidbody>().isKinematic = true;
            //collided++;
        }
    }

    void OnTriggerExit(Collider other) {
        grabbedGameObject = null;
    }
}
