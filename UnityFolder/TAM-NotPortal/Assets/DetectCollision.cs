using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour {
    AudioSource audioSource;

    // Useful: https://docs.unity3d.com/Manual/CollidersOverview.html
    bool collided;
    // Start is called before the first frame update
    MeshRenderer render;
    void Start () {
        audioSource = GetComponent<AudioSource> ();
        render = this.GetComponent<MeshRenderer> ();
        render.material.color = Color.red;
        collided = false;
    }

    // Update is called once per frame
    void Update () {

    }

    public bool get_collided () {
        return collided;
    }

    void OnTriggerEnter (Collider other) {

        audioSource.Play ();

        //MeshRender 
        if (other.gameObject.tag == "box") {
            collided = true;
            render.material.color = Color.green;
            //collided++;
        }
    }

    void OnTriggerExit (Collider other) {
        if (other.gameObject.tag == "box") {
            collided = false;
            //if(!collided){
            render.material.color = Color.red;
            // }
        }

    }
}