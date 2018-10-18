using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

    public Text winText;

   
    public float speed;

    float radius;
    Vector2 direction;

	// Use this for initialization
	void Start () {
        direction = Vector2.one.normalized;
        radius = transform.localScale.x / 2;
        winText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.y < GameManager.bottomLeft.y + radius && direction.y < 0){
            direction.y = -direction.y;
        }
        if (transform.position.y > GameManager.topRight.y - radius && direction.y > 0)
        {
            direction.y = -direction.y;
        }

        if (transform.position.x < GameManager.bottomLeft.x + radius && direction.x < 0)
        {
            Debug.Log("Right Player Wins!!");
           
            enabled = false;
            winText.text = "Right Player Wins!!";
        }
        if (transform.position.x > GameManager.topRight.x - radius && direction.x > 0)
        {
            Debug.Log("Left Player Wins!!");
      
            enabled = false;
            winText.text = "Left Player Wins!!";
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Paddle"){
            bool isRight = other.GetComponent<Paddle>().isRight;

            if(isRight == true && direction.x > 0){
                direction.x = -direction.x;
            }
            if (isRight == false && direction.x < 0)
            {
                direction.x = -direction.x;
            }
        }
    }
}
