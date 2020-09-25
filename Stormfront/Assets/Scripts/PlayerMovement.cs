using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    [SerializeField]
    float boostForce = 5.0f;
    Vector2 input;

    [SerializeField]
    Slider distanceSlider;
    [SerializeField]
    float initialDistance = 0f;
    [SerializeField]
    float finalDistance = 800f;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = GameObject.FindGameObjectWithTag("MainCamera").transform;
        initialDistance = rb.transform.position.x;
    }

    void Update()
    {
        //Distance
        distanceSlider.value = (rb.transform.position.x - initialDistance)/finalDistance;
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

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce((camF*input.y + camR*input.x)*boostForce);
        }else{
            rb.velocity = (camF*input.y + camR*input.x)*speed;        
        }
    }

    void FixedUpdate()
    {
        
        
    }
}
