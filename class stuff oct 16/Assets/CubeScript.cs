using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("fade");
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    IEnumerator fade(){
        for (float i = 1f; i >= 0; i -= 0.1f){
            Color c = GetComponent<Renderer>().material.color;
            c.a = i;
            yield return null;
        }
    }


}
