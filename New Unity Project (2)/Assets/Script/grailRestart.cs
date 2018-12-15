using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class grailRestart : MonoBehaviour {

    bool got;


    // Use this for initialization
    void Start () {
        got = false;
	}
	
	// Update is called once per frame
	void Update () {

        //if (got == true)
        //{
        //    scoreCount.winCount = scoreCount.winCount + 1;
        //}

    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{

        //    if (other.gameObject.CompareTag("Player"))
        //    {
        //        this.gameObject.SetActive(false);

        //        Invoke("restart", 1);
        //    got = true;
        //    if (got == true)
        //    {
        //        scoreCount.winCount=scoreCount.winCount+1;
        //    }

        //    Debug.Log("touching player");
        //    }
        //}

 
}




