using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public float jump;
    public float speed;

	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown (KeyCode.UpArrow)){
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * jump, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.right * speed, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.left * speed, ForceMode2D.Impulse);
        }

    }
}
