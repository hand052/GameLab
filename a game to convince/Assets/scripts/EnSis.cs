using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnSis : MonoBehaviour {

    string speech;
    Text charSpeech;

    public GameObject lady;
    public GameObject speechScript;


    // Use this for initialization
    void Start()
    {
        charSpeech = speechScript.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (charSpeech.text == "Lady")
        {
            lady.SetActive(true);

        }


        if (charSpeech.text == "Doctor")
        {
            lady.SetActive(false);
        }
        if (charSpeech.text == "Business Man")
        {
            lady.SetActive(false);
        }
        if (charSpeech.text == "Maid")
        {
            lady.SetActive(false);
        }
        if (charSpeech.text == "")
        {
            lady.SetActive(false);
        }


    }
}
