using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class health2 : MonoBehaviour {

    public GameObject h1;
    public GameObject h2;
    public GameObject h3;
 
    int l;
    public SpriteRenderer sr;

    // Use this for initialization
    void Start()
    {
        l = 3;

        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (l == 3)
        {
            h1.SetActive(true);
            h2.SetActive(true);
            h3.SetActive(true);
           
        }
        if (l == 2)
        {
            h1.SetActive(true);
            h2.SetActive(true);
            h3.SetActive(false);
          
        }
        if (l == 1)
        {
            h1.SetActive(true);
            h2.SetActive(false);
            h3.SetActive(false);
        }
        if (l == 0)
        {
            h1.SetActive(false);
            h2.SetActive(false);
            h3.SetActive(false);
        }

    }

    void turnW()
    {
        sr.material.color = Color.green;
    }
    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("enemy"))
        {
            l = l - 1;


            sr.material.color = Color.red;

            Invoke("turnW", .2f);


            if (l == 0)
            {
                sr.enabled = false;

                Invoke("restart", .7f);
                //l = 2;
            }

        }

    }
}
