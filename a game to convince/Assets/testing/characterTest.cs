using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterTest : MonoBehaviour {

    public Character Doc;

	// Use this for initialization
	void Start () {
        Doc = characterManager.instance.GetCharacter("Doc");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
