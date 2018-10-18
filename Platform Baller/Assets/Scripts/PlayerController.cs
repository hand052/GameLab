using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;
    public Text loseText;
    public int sceneNum;
    public bool onGround;
  

    private Rigidbody rb;
    private int count;


    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
        winText.text = "";
        loseText.text = "";
       

	}

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            setCountText();
        }

        if (other.gameObject.CompareTag("Pick Up S"))
        {
            other.gameObject.SetActive(false);
            count = count + 5;
            setCountText();
        }
    }

    void setCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 20)
        {
            SceneManager.LoadScene(sceneNum);
        }
        else if (count >= 40)
        {
            winText.text = "You Won!!";
        }



    }


   



    void Update()
    {
        if (onGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody>().velocity = Vector3.up * speed;
                onGround = false;
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("ground"))
        {
            onGround = true;
        }
    }
}
