using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutineprinter : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("Wait2Seconds");
        Debug.Log("Hello!");
	}

    IEnumerator Wait2Seconds()
    {
        Debug.Log("1");
        yield return new WaitForSeconds(2);
        Debug.Log("2");
        yield return new WaitForSeconds(2);
        Debug.Log("3");


    }
}
