using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitAroundObject : MonoBehaviour
{   
    [SerializeField] private GameObject target;
    [SerializeField] private float Speed;
    private Vector3 giro = Vector3.up;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, giro, Speed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.X)){
             giro = Vector3.right;
        }
         if(Input.GetKeyDown(KeyCode.Y)){
             giro = Vector3.up;
        }
         if(Input.GetKeyDown(KeyCode.Z)){
             giro = Vector3.forward;
        }
    }
}
