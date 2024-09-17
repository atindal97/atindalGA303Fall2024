using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject cubeDrop;
    public GameObject platformTrigger;
    public GameObject cannonBall;

    public float cannonBallSpeed = 300f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cubeDrop.SetActive(true);
        }
    }

    public void OnCollisionEnter(Collision platform)
    {
        //cannonBall.SetActive(false);
        Debug.Log("Button has been touched, release the ball.");
        cannonBall.SetActive(true);
        cannonBall.GetComponent<Rigidbody>().AddForce(new Vector3(-10, 1, 0) * cannonBallSpeed);
    }

}
