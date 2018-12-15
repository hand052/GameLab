using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winChange : MonoBehaviour
{
    public Text winScoreText;
    public Text diedScoreText;


 

    // Update is called once per frame
    void Update()
    {
        diedScoreText.text = "Died: " + scoreCount.dieCount.ToString();

        winScoreText.text = "Wins: " + scoreCount.winCount.ToString();

    }
}
