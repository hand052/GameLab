using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour {

    public int sceneNum;

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, (Screen.height / 2)-40, 100, 40), "Start"))
            SceneManager.LoadScene(sceneNum);
    }
}
