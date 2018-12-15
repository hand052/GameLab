using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showCollected : MonoBehaviour {

    public Image pacman_icon, pokemon_icon, shroom1, shroom2, shroom3;

	// Use this for initialization
	void Start () {
        shroom1.enabled = false;
        shroom2.enabled = false;
        shroom3.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {

        pacman_icon.enabled = gameManager.control.pacmanUnlocked;
        pokemon_icon.enabled = gameManager.control.pacmanUnlocked;


        if(gameManager.control.shroomCount == 0){
            shroom1.enabled = false;
            shroom2.enabled = false;
            shroom3.enabled = false;
        }
        else if(gameManager.control.shroomCount==1){
            shroom1.enabled = true;
        }else if(gameManager.control.shroomCount == 2){
            shroom2.enabled = true;
        }else if(gameManager.control.shroomCount == 3){
            shroom3.enabled = true;
        }
    }
}
