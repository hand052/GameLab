using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canonSpawner : MonoBehaviour {

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

            xPos = Random.Range(11, 29);

            spawn = new Vector2(xPos, -1.8f);

            Instantiate(enemy, spawn, Quaternion.identity);
        }
    }
    
    // Update is called once per frame
    void Update () {
        
    }
}
