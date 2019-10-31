using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    public DetectCollision toCheck;
    public DetectCollision toCheck2;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(toCheck.get_collided() && toCheck2.get_collided()){
            SceneManager.LoadScene("Warehouse2");
        }
    }
}
