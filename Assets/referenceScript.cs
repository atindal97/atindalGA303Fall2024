using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class referenceScript : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        heyIsThisThingOn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void heyIsThisThingOn()
    {
        Debug.Log("Hey, is this thing on?");
    }
}
