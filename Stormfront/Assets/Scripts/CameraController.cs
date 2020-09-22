using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.position + new Vector3(0.0f, 10.7f, -10.0f);
        transform.position = Vector3.Lerp(transform.position, playerPos, 0.1f);
    }
}
