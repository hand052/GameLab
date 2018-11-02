using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enableChar : MonoBehaviour
{
   string speech;
    Text charSpeech;

    public GameObject doctor;
    public GameObject speechScript;


    // Use this for initialization
    void Start()
    {
        charSpeech = speechScript.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(charSpeech.text=="Doctor") {
            doctor.SetActive(true);

        }


        if(charSpeech.text=="Maid"){
            doctor.SetActive(false);
        }
        if (charSpeech.text == "Business Man")
        {
            doctor.SetActive(false);
        }
        if (charSpeech.text == "Lady")
        {
            doctor.SetActive(false);
        }
        if (charSpeech.text == "")
        {
            doctor.SetActive(false);
        }
        if (charSpeech.text == "Narrator")
        {
            doctor.SetActive(false);
        }

    }
}

