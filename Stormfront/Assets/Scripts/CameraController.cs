using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Transform player;
    [SerializeField]
    float lerpT = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    void Update()
    {
        //Janky camera rotation
        /*heading += Input.GetAxis("Mouse X")*Time.deltaTime*180;
        camPivot.rotation = Quaternion.Euler(0,heading,0);*/
    }

    void FixedUpdate()
    {
        Vector3 playerPos = player.position + new Vector3(0.0f, 10.7f, -10.0f);
        transform.position = Vector3.Lerp(transform.position, playerPos, lerpT);
    }
}
