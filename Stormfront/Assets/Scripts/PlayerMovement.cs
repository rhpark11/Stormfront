using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //The way we're trying to rotate the camera is not the best way
    //But it's super quick and dirty
    /*[SerializeField]
    Transform camPivot;
    float heading = 0;*/
    [SerializeField]
    Rigidbody rb;

    [SerializeField]
    Transform cam;
    [SerializeField]
    float speed = 5.0f;
    Vector2 input;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }
    void FixedUpdate()
    {
        //Player movement
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        input = Vector2.ClampMagnitude(input, 1);
        
        //Quick and dirty method to have camera relative movement inputs
        //Another way is to transform input vector into camera relative directions
        //Camera forward and right vectors
        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;
        camF.y = 0;
        camR.y = 0;
        camF = camF.normalized;
        camR = camR.normalized;

        rb.velocity = (camF*input.y + camR*input.x)*speed;        
    }
}
