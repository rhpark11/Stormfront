using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleManager : MonoBehaviour
{
    [SerializeField]
    int commonC;
    [SerializeField]
    int uncommonC;
    [SerializeField]
    int rareC;
    [SerializeField]
    int ultraRareC;

    [SerializeField]
    TextMeshProUGUI commonCT;
    [SerializeField]
    TextMeshProUGUI uncommonCT;
    [SerializeField]
    TextMeshProUGUI rareCT;
    [SerializeField]
    TextMeshProUGUI ultraRareCT;
    // Start is called before the first frame update
    void Start()
    {
        commonC = 0;
        uncommonC = 0;
        rareC = 0;
        ultraRareC = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Collectible")
        {            
            if(other.name == "Common")
            {
                commonC++;
                commonCT.text = commonC.ToString();
                other.gameObject.SetActive(false);
            }
            else if(other.name == "Uncommon")
            {
                uncommonC++;
                uncommonCT.text = uncommonC.ToString();
                other.gameObject.SetActive(false);
            }
            else if(other.name == "Rare")
            {
                rareC++;
                rareCT.text = rareC.ToString();
                other.gameObject.SetActive(false);
            }
            else if(other.name == "Ultra Rare")
            {
                ultraRareC++;
                ultraRareCT.text = ultraRareC.ToString();
                other.gameObject.SetActive(false);
            }
            else
            {
                Debug.Log("Unknown Collectible");
            }
        }
        
    }
}
