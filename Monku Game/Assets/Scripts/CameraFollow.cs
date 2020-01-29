using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    
    private Transform playerTransform;

    public float offset;

    void Start ()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;   
    }

    private void Update ()
    {
        
    }

    void LateUpdate ()
    {
        Vector3 temp = transform.position; 

        temp.x = playerTransform.position.x; 
        temp.y = playerTransform.position.y;

        temp.x += offset; 

        transform.position = temp;
    }
}
