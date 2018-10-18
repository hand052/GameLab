using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBounce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame

    float speed = 5f;
    float height = .5f;

	void Update () {
        Vector2 pos = transform.position;
        float newY = Mathf.Sin(Time.time * speed)*.25f;
        transform.position = new Vector2(pos.x, newY);
	}
}
