using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAcceleration : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private float MaxSpeed;
    [SerializeField] private float Acceleration;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.Space)&& Speed < MaxSpeed){
        //   Speed = Speed+Acceleration*Time.deltaTime;
        //     transform.position += new Vector3(0f, 0f, Speed) * Time.deltaTime;
        //} else if (Speed > 0){
        //     transform.position += new Vector3(0f, 0f, Speed) * Time.deltaTime;
        //     Speed = Speed-Acceleration*Time.deltaTime;
        //}

        if (Input.GetKey(KeyCode.Space))
        {
            Speed += Time.deltaTime * 10f;
        }
        else
        {
            Speed -= Time.deltaTime * 10f;
        }

        Speed = Mathf.Clamp(Speed, 0f, 10f);

        
        
        transform.position += new Vector3(Speed, 0f, 0f) * Time.deltaTime;

    }
}
