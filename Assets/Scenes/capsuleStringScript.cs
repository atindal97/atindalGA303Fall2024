using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsuleStringScript : MonoBehaviour
{
    // Start is called before the first frame update

    public string phraseOne;
    public string phraseTwo;
    public string phraseThree;


    void Start()
    {
        phraseOne = "I love Anthony. ";
        phraseTwo = "Anthony likes Fortnite and Final Fantasy. ";
        phraseThree = "Kachow.";

        Debug.Log(phraseOne + phraseTwo + phraseThree);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
