﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePatrol : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(new Vector3(-10f, 0f, 0f), new Vector3(10f, 0f, 0f), Mathf.PingPong(Time.time, 1));
	}
}
