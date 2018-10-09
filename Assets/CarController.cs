using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    float speedForce =30f;
    float torqueForce = -200f;
    float driftFactorSlippy = 1;
    float driftFactorSticky = 0.9f;
    float maxStickyVelocity = 2.5f;
	// Use this for initialization
	void Start () {
		
	}
    void Update(){

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        float driftFactor = driftFactorSticky;
        if(RightVelocity().magnitude > maxStickyVelocity){
            driftFactor = driftFactorSlippy;
        }

        rb.velocity = ForwardVelocity() + RightVelocity() * driftFactor;

		if(Input.GetButtonDown("Accelerate")){
            rb.AddForce( transform.up * speedForce);
        }
        if(Input.GetButtonDown("Brake")){
            rb.AddForce( transform.up * -speedForce /2f);
        }

        rb.angularVelocity = Input.GetAxis("Horizontal") * torqueForce;

        if (Input.GetKeyDown(KeyCode.Escape)) {
        Application.Quit();
    }
	}
    Vector2 ForwardVelocity(){
        return transform.up * Vector2.Dot( GetComponent<Rigidbody2D>().velocity, transform.up);
    }
    Vector2 RightVelocity(){
        return transform.right * Vector2.Dot( GetComponent<Rigidbody2D>().velocity, transform.right);
    }
}
