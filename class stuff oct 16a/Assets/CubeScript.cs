using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

    public GameObject sphere;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("f")){
            StartCoroutine("fade");
        }
        StartCoroutine("sphereCheck");
	}

    IEnumerator sphereCheck(){
        float dist = Vector3.Distance(transform.position, sphere.transform.position);
        if (dist < 5f) {
            Debug.Log("oh no!");
        }else{
            Debug.Log("safe");
        }
        yield return new WaitForSeconds(0.1f);
    }
    IEnumerator fade(){
        for (float i = 1f; i >= 0; i -= 0.01f){
            Color c = GetComponent<Renderer>().material.color;
            c.a = i;
            GetComponent<Renderer>().material.color = c;
            yield return null;
        }
    }
}
