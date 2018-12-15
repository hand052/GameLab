using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner3 : MonoBehaviour {

    public GameObject enemy;
    float xPos;
    int r;

    // Use this for initialization
    void Start()
    {

        Vector2 spawn;

        r = Random.Range(1, 2);

        for (int i = 0; i < r; i++)
        {

            xPos = Random.Range(65, 77);

            spawn = new Vector2(xPos, -.06f);

            Instantiate(enemy, spawn, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}