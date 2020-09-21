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
    
    Vector2 input;
    
    void Update()
    {
        //Janky camera rotation
        /*heading += Input.GetAxis("Mouse X")*Time.deltaTime*180;
        camPivot.rotation = Quaternion.Euler(0,heading,0);*/

        //Plyaer movement
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        input = Vector2.ClampMagnitude(input, 1);
        
        //Quick and dirty method to have camera relative movement inputs
        //Another way is to transform input vector into camera relative directions
        Vector3 camU = cam.up;
        Vector3 camR = cam.right;
        camU.z = 0;
        camR.z = 0;
        camU = camU.normalized;
        camR = camR.normalized;

        //transform.position += new Vector3(input.x,0,input.y)*Time.deltaTime*5;
        transform.position += (camU*input.y + camR*input.x)*Time.deltaTime*5;
        
    }
}
