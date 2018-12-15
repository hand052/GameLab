using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class health3 : MonoBehaviour {


    public GameObject h1;
    public GameObject h2;
    bool got;


    int l;
    public SpriteRenderer sr;

    // Use this for initialization
    void Start()
    {
        l = 2;

        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

      

        if (l == 2)
        {
            h1.SetActive(true);
            h2.SetActive(true);
           
           
        }

        if (l == 1)
        {
            h1.SetActive(true);
            h2.SetActive(false);


        }

        if (l == 0)
        {
            h1.SetActive(false);
            h2.SetActive(false);
           
        }
        //if (got == true)
        //{
            //scoreCount.winCount=scoreCount.winCount+1;
       //}

    }

    void turnW()
    {
        sr.material.color = Color.blue;
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        print(other.gameObject.tag);
        if (other.gameObject.CompareTag("cup"))
        {
            print("touching cup");
            other.gameObject.SetActive(false);

            scoreCount.winCount++;
            //got = true;


            Invoke("restart", .7f);

        }
        if (other.gameObject.CompareTag("enemy"))
        {
            l = l - 1;


            sr.material.color = Color.red;

            Invoke("turnW", .2f);


            if (l == 0)
            {
                sr.enabled = false;

                scoreCount.dieCount++;

                Invoke("restart", .7f);
                //l = 3;
            }

        }

    }
}
