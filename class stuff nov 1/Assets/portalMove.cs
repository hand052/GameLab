using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalMove : MonoBehaviour {

    public GameObject cubePortal, spherePortal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.UpArrow)){
            transform.Translate(transform.forward * 5 * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(transform.forward * -5 * Time.deltaTime);
        }
       


    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Cube") {
            transform.position = spherePortal.transform.position + new Vector3 (-4, 0, 0);
        }
      
        if (other.gameObject.name == "Sphere")
        {
            transform.position = cubePortal.transform.position + new Vector3 (4, 0, 0);
        }
    }

}
