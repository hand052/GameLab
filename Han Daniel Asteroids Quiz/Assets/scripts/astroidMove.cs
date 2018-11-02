using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidMove : MonoBehaviour {
   
    float posX, posY;
    public float speed;

    private void Start()
    {
        posX = Random.Range(-9, 9);
        posY = Random.Range(-6, 6);

        transform.position = new Vector2(posX, posY);

        Vector2 euler = transform.eulerAngles;
        euler.y = Random.Range(0f, 360f);
        transform.eulerAngles = euler;
    }

    private void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);

        ScreenWrap();
    }
    void ScreenWrap(){
        if (transform.position.x < -9){
            transform.position = new Vector2(8, transform.position.y);
        }
        if (transform.position.x > 9)
        {
            transform.position = new Vector2(-8, transform.position.y);
        }
        if (transform.position.y < -7)
        {
            transform.position = new Vector2(transform.position.x, 6);
        }
        if (transform.position.y > 7)
        {
            transform.position = new Vector2(transform.position.x, -6);
        }
    }
}
