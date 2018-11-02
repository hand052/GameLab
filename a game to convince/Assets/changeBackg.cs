using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeBackg : MonoBehaviour {

    string speech;
    Text charSpeech;

    public GameObject background1;
    public GameObject background2;
    public GameObject background3;
    public GameObject speechScript;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;

    // Use this for initialization
    void Start () {
        charSpeech = speechScript.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        if(charSpeech.text ==("Lets start the game.")){
            background1.SetActive(true);
        }
        if (charSpeech.text == ("He is a rather well off man "))
        {
            background1.SetActive(false);
            background2.SetActive(true);
        }
        if (charSpeech.text == ("After a lengthy disscusion after"))
        {
            background2.SetActive(false);
        }
        if (charSpeech.text == ("The next morning"))
        {
            background2.SetActive(true);
        }
        if (charSpeech.text == ("All agreeing in unison"))
        {
            background2.SetActive(false);
        }
        if (charSpeech.text == ("      "))
        {
            background3.SetActive(true);
        }

    }
}
