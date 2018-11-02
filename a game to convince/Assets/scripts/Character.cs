using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour {

    public string characterName;
    [HideInInspector] public RectTransform root;

   
 
    /// <summary>
    /// make a  new character
    /// </summary>
    /// <param name="_name">Name.</param>
    public Character (string _name)
    {
        characterManager cm = characterManager.instance;
        GameObject prefab = Resources.Load("Characters/Character[" +_name+ "]") as GameObject;
        GameObject ob = Instantiate(prefab, cm.characterPanel);

        root = ob.GetComponent<RectTransform>();
        characterName = _name;

        renderers.renderer = ob.GetComponentInChildren<RawImage>();
    }


    class Renderers{
        public RawImage renderer;
    }
    Renderers renderers=new Renderers();
}
