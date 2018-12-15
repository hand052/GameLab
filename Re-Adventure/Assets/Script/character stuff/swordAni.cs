using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordAni : MonoBehaviour {

    public GameObject rightsword;
    public GameObject leftsword;
    public AudioSource swinging;

    bool leftTrue;

    // Use this for initialization
    void Start () {

        leftTrue = false;
        swinging = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {


        //facing left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            leftTrue = true;

        }

        if (leftTrue==true){

            rightsword.SetActive(false);
            leftsword.SetActive(true);

        }
        //facing right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            leftTrue = false;
        }
     
        if(leftTrue==false)
        {
            rightsword.SetActive(true);
            leftsword.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && leftTrue==false){

            rightsword.transform.Rotate(0, 0, -95);

            Invoke("norm", .3f);

            swinging.Play(0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && leftTrue == true)
        {

            leftsword.transform.Rotate(0, 0, 95);

            Invoke("norm2", .3f);

            swinging.Play(0);
        }

    }

    void norm(){
        rightsword.transform.Rotate(0, 0, 95);
    }
    void norm2()
    {
        leftsword.transform.Rotate(0, 0, -95);
    }
}
