using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsuleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public char letterOne;
    public char letterTwo;
    public char letterThree;
    public char letterFour;
    public char letterFive;
    public char letterSix;


    void Start()
    {
        letterOne = 'G';
        letterTwo = 'U';
        letterThree = 'N';
        letterFour = 'N';
        letterFive = 'E';
        letterSix = 'R';
        Debug.Log("Gunner is spelled: " + letterOne + letterTwo + letterThree + letterFour + letterFive + letterSix);

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
