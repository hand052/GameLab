using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnMan : MonoBehaviour {

    string speech;
    Text charSpeech;

    public GameObject man;
    public GameObject speechScript;


    // Use this for initialization
    void Start()
    {
        charSpeech = speechScript.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (charSpeech.text == "Business Man")
        {
            man.SetActive(true);

        }


        if (charSpeech.text == "Doctor")
        {
            man.SetActive(false);
        }
        if (charSpeech.text == "Maid")
        {
            man.SetActive(false);
        }
        if (charSpeech.text == "Lady")
        {
            man.SetActive(false);
        }
        if (charSpeech.text == "")
        {
            man.SetActive(false);
        }


    }
}
