using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    DialogueSystem dialogue;

    void Say(string s)
    {
        string[] parts = s.Split(':');
        string speech = parts[0];
        string speaker = (parts.Length >= 2) ? parts[1] : "";

        dialogue.Say(speech, speaker);
    }

    // Use this for initialization
    void Start () {
        dialogue = DialogueSystem.instance;
	}

    public string[] s = new string[]
    {
        "Lets start the game.:Narrator",
       "We begin our setting in London in the year 1730.",
        "Our little game takes us to the finer side of town to a noble man's house.",
        "He is a rather well off man and has decided to invite two of his friends to dinner.",
        "His close friend since childhood, Docter Jack Raikov.:Doctor",
        "And a close business associate, Mr. Jabez Ross.:Business Man",
        "With them is also his sister, Lady Dolarina.:Lady",
        "And attending to them is the Head Maid, Miss Anna.:Maid",
        "After a lengthy disscusion after dinner his friends decided to spend the night and resume their conversations after breakfest over some tea.:Narrator",
        "But I'm sure you all know what happens next..;)",
        "The next morning as they woke up and ate their breakfest, they noticed something.",
        "Uh.. Rina do you know where your brother is, it's not like him to skip a meal.:Doctor",
        "I don't quiet know Jack, Miss Anna do you know where he is?:Lady",
        "No mi,Lady he wasn't there when I went to wake him up.:Maid",
        "Perhaps we should go look for him.:Business Man",
        "All agreeing in unison, they all head out and searched for him.:Narrator",
        "Until they heard something.",
        "Aaaaaaaaah!!!!!",
        "Surprised they rushed to the sound and find a pale Lady Dolarina staring mouth agaped into her brother's study.",
        "What's wrong Rina, what happened?!?!:Doctor",
        "It's my brother.. he's.. *hi*..*sob*..*hi*.. he's...:Lady",
        "             :Narrator",
        "                   He's Dead!!!!!             *SOB**SOB**SOB**SOB**SOB*!!!!!:Lady"

    };

   

    int index = 0;
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!dialogue.isSpeaking || dialogue.isWaitingForUserInput)
            {
                if(index >= s.Length)
                {
                    return;
                }

                Say(s [index]);
                index++;
            }
        }
	}

}