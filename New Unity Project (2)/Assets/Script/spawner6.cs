﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner6 : MonoBehaviour {

    public GameObject enemy;
    float xPos;
    int r;

    // Use this for initialization
    void Start()
    {

        Vector2 spawn;

        r = Random.Range(1, 3);

        for (int i = 0; i < r; i++)
        {

            xPos = Random.Range(141, 155);

            spawn = new Vector2(xPos, 3.78f);

            Instantiate(enemy, spawn, Quaternion.identity);
        }
    }
}