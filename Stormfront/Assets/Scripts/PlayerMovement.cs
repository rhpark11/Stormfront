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
    Transform cam;
    [SerializeField]
    float speed = 5.0f;
    Vector2 input;
    
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }
    void Update()
    {
        //Janky camera rotation
        /*heading += Input.GetAxis("Mouse X")*Time.deltaTime*180;
        camPivot.rotation = Quaternion.Euler(0,heading,0);*/

        //Player movement
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        input = Vector2.ClampMagnitude(input, 1);
        
        //Quick and dirty method to have camera relative movement inputs
        //Another way is to transform input vector into camera relative directions
        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;
        camF.y = 0;
        camF.y = 0;
        camF = camF.normalized;
        camR = camR.normalized;

        //transform.position += new Vector3(input.x,0,input.y)*Time.deltaTime*5;
        transform.position += (camF*input.y + camR*input.x)*Time.deltaTime*speed;
        
    }
}
