using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    public GameObject arrow;
    public Transform bow;
    public AudioSource shootSound;

    public GameObject rightBow;
    public GameObject leftBow;
    private bool ready;

    float direction;
    bool leftTrue;

    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var Arrow = (GameObject)Instantiate(
            arrow,
            bow.position,
            bow.rotation);

        // Add velocity to the bullet
        Arrow.GetComponent<Rigidbody2D>().velocity = Arrow.transform.right * 30*direction;

        // Destroy the bullet after 2 seconds


       


        Destroy(Arrow, 2.0f);
    }

    // Use this for initialization
    void Start () {
        direction = 1;
        leftTrue = false;

        leftBow.SetActive(false);

        ready = true;

        shootSound = GetComponent<AudioSource>();
	}

    void reload(){
        ready = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && ready == true)
        {
            Fire();
            ready = false;
            Invoke("reload", .6f);
            shootSound.Play(0);
        }
        //facing left
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            leftTrue = true;
            direction = -1;
            rightBow.SetActive(false);
            leftBow.SetActive(true);
        }
        //facing right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            leftTrue = false;
            direction = 1;
            rightBow.SetActive(true);
            leftBow.SetActive(false);
        }
    }

    // void OnTriggerEnter2D(Collider2D other)
    //{
    //    if(other.CompareTag("enemy")){
    //        gameObject.SetActive(false);
    //        other.gameObject.SetActive(false);
    //    }
    //}
}
