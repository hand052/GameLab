using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class health1 : MonoBehaviour
{

    public GameObject h1;
    public GameObject h2;
    public GameObject h3;
    public GameObject h4;
    public GameObject h5;
    int l;
    public SpriteRenderer sr;
    bool got;

    // Use this for initialization
    void Start()
    {
        l = 5;

        sr = GetComponent<SpriteRenderer>();

        got = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(l==5){
            h1.SetActive(true);
            h2.SetActive(true);
            h3.SetActive(true);
            h4.SetActive(true);
            h5.SetActive(true);
        }
        if (l == 4)
        {
            h1.SetActive(true);
            h2.SetActive(true);
            h3.SetActive(true);
            h4.SetActive(true);
            h5.SetActive(false);
        }
        if (l == 3)
        {
            h1.SetActive(true);
            h2.SetActive(true);
            h3.SetActive(true);
            h4.SetActive(false);
            h5.SetActive(false);
        }
        if (l == 2)
        {
            h1.SetActive(true);
            h2.SetActive(true);
            h3.SetActive(false);
            h4.SetActive(false);
            h5.SetActive(false);
        }
        if (l == 1)
        {
            h1.SetActive(true);
            h2.SetActive(false);
            h3.SetActive(false);
            h4.SetActive(false);
            h5.SetActive(false);
        }
        if (l == 0)
        {
            h1.SetActive(false);
            h2.SetActive(false);
            h3.SetActive(false);
            h4.SetActive(false);
            h5.SetActive(false);
        }

        //if(got==true){
        //    scoreCount.winCount= scoreCount.winCount+1;
        //}

    }

    void turnW()
    {
        sr.material.color = Color.yellow;
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if(other.gameObject.CompareTag("cup")){
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
                sr.enabled=false;

                scoreCount.dieCount++;

                Invoke("restart", .7f);
                //l = 5;
            }

        }

    }
}
