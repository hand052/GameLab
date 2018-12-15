using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyMove : MonoBehaviour
{

    public int speed;
     int l;
    public SpriteRenderer sr;

    private void Start()
    {
        l = 2 + scoreCount.winCount;
    }


    // Update is called once per frame
    void Update()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);

        sr = GetComponent<SpriteRenderer>();

        sr.color = new Color(255-10*scoreCount.winCount, 255 - 10 * scoreCount.winCount, 255 - 10 * scoreCount.winCount);

    }

    void turnW()
    {
        sr.material.color = Color.white;
    }

    void turnB()
    {
        sr.color = Color.black;
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            speed = -speed;
        }

        //if (other.gameObject.CompareTag("weapon") && Input.GetKeyDown(KeyCode.Space))
        //{
        //    this.gameObject.SetActive(false);

        //}

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        //if (other.gameObject.CompareTag("wall"))
        //{
        speed = -speed;
        //}

        if (other.gameObject.CompareTag("arrow"))
        {
            l = l - 1;

            other.gameObject.SetActive(false);


            sr.material.color = Color.red;

            Invoke("turnW", .1f);


            if (l == 0)
            {


                this.gameObject.SetActive(false);


            }



        }
    }

    void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("weapon") && Input.GetKeyDown(KeyCode.Space))
        {
            l = l - 2;

          
            sr.material.color = Color.red;

            Invoke("turnW", .1f);


            if (l <= 0)
            {


                this.gameObject.SetActive(false);


            }

        }

    }
}
