using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class UIScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Toggle yesAnswer;
    public Image dogImage;
    public referenceScript popUp;
    public Image helpDoggo;


    void Start()
    {
        popUp.heyIsThisThingOn();
        dogImage.gameObject.SetActive(false);
        helpDoggo.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (yesAnswer.isOn)
        {
            dogImage.gameObject.SetActive(true);
        }
        else
        {
            dogImage.gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            helpDoggo.gameObject.SetActive(true);
            doggoHelp();
        }
       
    }

    public void doggoHelp()
    {
        helpDoggo.gameObject.transform.position += new Vector3(0, -276, 0) * Time.deltaTime;
    }

}

