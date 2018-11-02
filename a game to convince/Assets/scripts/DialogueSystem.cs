using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour {

    public static DialogueSystem instance;

    public ELEMENTS elements;

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {
        
    }

    /// <summary>
    /// Say something and show it on the speech bubble
    /// </summary>
    public void Say(string speech, string speaker = ""){
        stopSpeaking();

        speaking = StartCoroutine(Speaking(speech, false, speaker));
    }

    /// <summary>
    /// Say something to add on to the speech bubble
    /// </summary>
    public void SayAdd(string speech, string speaker = "")
    {
        stopSpeaking();

        SpeechText.text = targetSpeech;
        //SpeechText.text = "";
        //print(targetSpeech);

        speaking = StartCoroutine(Speaking(speech, true, speaker));
    }


    public void Say(string speech, bool additive = false, string speaker = ""){
        stopSpeaking();

        SpeechText.text = targetSpeech;

        speaking = StartCoroutine(Speaking(speech, additive, speaker));
    }

    void stopSpeaking(){
        if (isSpeaking){
            StopCoroutine(speaking);
        }
        speaking = null;
    }
    
    public bool isSpeaking { get { return speaking != null; }}
    [HideInInspector] public bool isWaitingForUserInput = false;

    string targetSpeech = "";
    Coroutine speaking = null;
    IEnumerator Speaking(string speech, bool additive, string speaker = ""){
        SpeechBubble.SetActive(true);
        targetSpeech = speech;

        if (!additive)
            SpeechText.text = "";
        else
            targetSpeech = SpeechText.text + targetSpeech;
        SpeakerNameText.text = DetermineSpeaker(speaker);//temp
        isWaitingForUserInput = false;

        while(SpeechText.text != targetSpeech){
            SpeechText.text += targetSpeech[SpeechText.text.Length];
            yield return new WaitForEndOfFrame();
        }
        //text finished
        isWaitingForUserInput = true;
        while (isWaitingForUserInput)
            yield return new WaitForEndOfFrame();

        stopSpeaking();
    }

    string DetermineSpeaker(string s){
        string retVal = SpeakerNameText.text;//default return is current name
        if (s != SpeakerNameText.text && s != "")
            retVal = (s.ToLower().Contains("narrator")) ? "" : s;

        return retVal;
    }

    [System.Serializable]
    public class ELEMENTS{
        /// <summary>
        /// speech buuble with dialogue
        ///</summary>
        public GameObject speechBubble;
        public Text speakerNameText;
        public Text speechText;

    }
    public GameObject SpeechBubble { get { return elements.speechBubble; }}
    public Text SpeakerNameText { get { return elements.speakerNameText; } }
    public Text SpeechText { get { return elements.speechText; } }
}
