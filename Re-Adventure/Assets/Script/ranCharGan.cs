using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ranCharGan : MonoBehaviour {

    int x;

    public GameObject p1;
    public GameObject p2;


    // Use this for initialization
    void Start () {

       x = Random.Range(1, 3);
        //Debug.Log(x);

        if(x==1){
            p1.SetActive(true);
            p2.SetActive(false);
         
        }
        if (x == 2)
        {
            p2.SetActive(true);
            p1.SetActive(false);
           
        }
     

    }
	
	// Update is called once per frame
	void Update () {
	

	}
}
