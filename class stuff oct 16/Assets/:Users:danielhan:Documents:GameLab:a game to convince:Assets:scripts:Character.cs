using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Character : MonoBehaviour {

    public string name;

    public characters (string name){
        characterManager cm = characterManager.instance;
        GameObject prefab = Resources.Load("characters/Character[" + name + "])
    }
}
