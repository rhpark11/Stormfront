using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject commonC;
    [SerializeField]
    GameObject uncommonC;
    [SerializeField]
    GameObject rareC;
    [SerializeField]
    GameObject ultraRareC;

    
    // Start is called before the first frame update
    void Start()
    {
        int num = Random.Range(0,4);
        switch (num)
        {
            case 0:
                commonC.SetActive(true);
                break;
            case 1:
                uncommonC.SetActive(true);
                break;
            case 2:
                rareC.SetActive(true);
                break;
            case 3:
                ultraRareC.SetActive(true);
                break;
        }
               
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
