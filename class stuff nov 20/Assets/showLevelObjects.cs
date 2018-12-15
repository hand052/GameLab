using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showLevelObjects : MonoBehaviour {

    public GameObject pokemonGate;
    public GameObject shroom1, shroom2, shroom3;

	// Use this for initialization
	void Start () {
        pokemonGate.SetActive(gameManager.control.pokemonUnlocked);
	}
	
	
}
