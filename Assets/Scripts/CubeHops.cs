using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeHops : MonoBehaviour
{

     [SerializeField] private Rigidbody rbComponent;
    [SerializeField] private float jumpForce;
    [SerializeField] private float time;
    private float currentTime;
    private int a = UnityEngine.Random.Range(0, 2);
    private bool Boolean;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        
        if (a == 0) 
            Boolean = false;
        else       
        Boolean = true;

        //if (currentTime <= 0)
        //{
        //    rbComponent.AddForce(jumpForce, jumpForce, 0f);
        //    rbComponent.AddTorque(0f, 0f, -jumpForce * 0.5f);
        //    currentTime = time;
        //}





        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            if (Boolean)
            {
                rbComponent.AddForce(jumpForce, jumpForce, 0f);
            }
            else
            {
                rbComponent.AddForce(-jumpForce, jumpForce, 0f);
            }
            
           
            currentTime = time;
        }
    }
}
