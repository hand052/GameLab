using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideScrolling : MonoBehaviour {

    public float scroll;
    public float dis;

    private Vector2 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scroll, dis);
        transform.position = startPosition + Vector2.left * newPosition;
    }
}