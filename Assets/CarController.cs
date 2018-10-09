using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    float speedForce =-20f;
    float torqueForce = -2f;
	// Use this for initialization
	void Start () {
		
	}
    void Update(){

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

		if(Input.GetButtonDown("Accelerate")){
            rb.AddForce( transform.right * speedForce);
        }
        rb.AddTorque(Input.GetAxis("Horizontal") * torqueForce);

        //rb.velocity = ForwardVelocity();
	}
/*
    Vector2 ForwardVelocity(){
        return transform.up * Vector2.Dot( GetComponent<Rigidbody2D>().velocity, transform.right);
    }
    Vector2 RightVelocity(){
        return transform.up * Vector2.Dot( GetComponent<Rigidbody2D>().velocity, transform.right);
    }*/
}
