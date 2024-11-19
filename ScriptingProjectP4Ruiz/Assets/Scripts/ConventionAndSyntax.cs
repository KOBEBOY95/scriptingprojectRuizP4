using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //I  want the x position of my game object to ap[pear on the console
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<=5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
            

    }
}
