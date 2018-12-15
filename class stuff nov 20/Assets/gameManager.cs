using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

    public static gameManager control;

    public bool pacmanUnlocked, pokemonUnlocked;
    public int shroomCount;

        void Awake()
        {
            // 3 - if there's no gamecontrol, make this the game control
            if (control == null)
            {
                DontDestroyOnLoad(gameObject);
                control = this;   // this means this script
            }
            else if (control != this)
            {
                Destroy(gameObject);  // there can be only one
            }

        }
    private void Start()
    {
        pacmanUnlocked = true;
        pokemonUnlocked = false;
        shroomCount = 0;
    }


}
