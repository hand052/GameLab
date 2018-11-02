using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnMaid : MonoBehaviour {

    string speech;
    Text charSpeech;

    public GameObject maid;
    public GameObject speechScript;


    // Use this for initialization
    void Start()
    {
        charSpeech = speechScript.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (charSpeech.text == "Maid")
        {
            maid.SetActive(true);

        }


        if (charSpeech.text == "Doctor")
        {
            maid.SetActive(false);
        }
        if (charSpeech.text == "Business Man")
        {
            maid.SetActive(false);
        }
        if (charSpeech.text == "Lady")
        {
            maid.SetActive(false);
        }
        if (charSpeech.text == "")
        {
            maid.SetActive(false);
        }
        if (charSpeech.text == "Narrator")
        {
            maid.SetActive(false);
        }


    }
}
