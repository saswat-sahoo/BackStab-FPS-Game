using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     public Rigidbody rb;
    public float Force = 10f;
    
    void Start()
    {
        
    }

    void Update()
    {
    // basic movement for player
    if(Input.GetKey("d")){
    rb.AddForce(Force * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
    }
    if(Input.GetKey("a")){
    rb.AddForce(-Force * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
    }
    if(Input.GetKey("w")){
    rb.AddForce(0, 0 , Force * Time.deltaTime, ForceMode.VelocityChange);
    }
    if(Input.GetKey("s")){
    rb.AddForce(0, 0 , -Force * Time.deltaTime, ForceMode.VelocityChange);
    }

   
    }
}
