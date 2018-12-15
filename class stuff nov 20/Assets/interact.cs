using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class interact : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="shroom"){
            gameManager.control.shroomCount++;
            Destroy(other.gameObject);

        }
        if (other.gameObject.tag == "gate"){
            if(other.gameObject.name == "pacman gate"){
                SceneManager.LoadScene("pacman");
            }
            if(other.gameObject.name=="home gate"){
                SceneManager.LoadScene("home");
            }
        }
    }
}
