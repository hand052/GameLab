using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

    public int speed;
    public float jump;
    public Rigidbody2D rb;
    private bool touching;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D>();

        touching = true;

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.W) && touching==true)
        {
            rb.velocity += Vector2.up * jump;

            touching = false;

        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && touching == true)
        {
            rb.velocity += Vector2.up * jump;

            touching = false;

        }

        //if (Input.GetKey(KeyCode.D))
        //{
        //    GetComponent<Rigidbody2D>().AddForce(Vector3.right * speed, ForceMode2D.Impulse);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    GetComponent<Rigidbody2D>().AddForce(Vector3.left * speed, ForceMode2D.Impulse);
        //}


        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity+= Vector2.right;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity += Vector2.left ;
        }


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("ground")){
            touching = true;
        }

        if (other.gameObject.CompareTag("wall"))
        {
            touching = true;
        }
    }
}
