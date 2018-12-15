using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showPacmanLevel : MonoBehaviour {

    public GameObject key, enemy;

	// Use this for initialization
	void Start () {

        if (gameManager.control.shroomCount == 3)
        {
            enemy.SetActive(false);
        }
        else if()
        {
            key.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
