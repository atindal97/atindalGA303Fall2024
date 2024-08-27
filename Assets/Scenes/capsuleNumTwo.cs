using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class capsuleNumTwo : MonoBehaviour
{
    // Start is called before the first frame update

    public int num1 = 5;
    public int num2 = 8;
    public float num3 = 2.3f;
    public float num4 = 4.5f;

    public float total = 0f;


    void Start()
    {
      Add();
      Subtract();
      Multiply();
      Divide();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Add()
    {
        Debug.Log("Starting total is " + total);
        total = total + num1;
        Debug.Log("Added " + num1 + " to total, making total " + total);
        total = total + num2;
        Debug.Log("Added" + num2 + " to toal, making total " + total);

       // total = num1 + num2;
       // Debug.Log(total);
    }

    void Subtract()
    {
        total = 1;
        Debug.Log("Starting total is " + total);
        total = total - num2;
        Debug.Log("Subtracted " + num2 + " to total, making total " + total);
        total = total - num1;
        Debug.Log("Subtracted " + num1 + " to total, making total " + total);


        //total = num2 - num1;
        //Debug.Log(total);
    }

    void Multiply()
    {
        total = 1f;

        Debug.Log("Starting total is " + total);
        total = total * num2;
        Debug.Log("Multiplied " + num2 + " to total, making total " + total);
        total = total * num4;
        Debug.Log("Mulitpled " + num4 + " to total, making total " + total);


       // total = (float)num2 * num4;
       // Debug.Log(total);

    }

    void Divide ()
    {
        total = 10f;
        Debug.Log("Starting total is " + total);
        total = total / num3;
        Debug.Log("Divided by " + num3 + " to total, making total " + total);
        total = total / num4;
        Debug.Log("Divided by" + num4 + " to total, making total " + total);

        //total = num2 / num4;
        //Debug.Log(total.ToString());
    }

}
