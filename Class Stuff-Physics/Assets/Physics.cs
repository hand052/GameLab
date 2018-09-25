using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter () {
		
	}

    void OnCollisionStay (Collision other){
//      Debug.Log ("i'm still touching!!");

    	// GetComponent<Rigidbody> ().AddForce (Vector3.up * upforce);

    	if (other.gameObject.tag == "sphere") {
    		gameObject.GetComponent<Renderer> ().material.color = Color.green;
    	}
    
    }

    void OnCollisionExit (Collision other){
    	// Debug.Log ("no longer touching");
    	if (other.gameObject.tag == "sphere") {
    		gameObject.GetComponent<Renderer> ().material.color = Color.red;
    	}
    }
    
    public float upforce;

    void OnMouseDown(){
    	GetComponent<Rigidbody> ().AddForce (Vector3.up * upforce, ForceMode.Impluse);
    	GetComponent<Rigidbody> ().AddTorque (Vector3.up * upforce);
    }


    void OnTriggerEnter (Collider other){

    }
}
