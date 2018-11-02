using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidSpawner : MonoBehaviour
{
    public GameObject asteroid;

    private void Start()
    {
        for (int i = 0; i < 8; i++){
            Instantiate(asteroid, new Vector2(3, 3), Quaternion.identity);
        }
    }

}