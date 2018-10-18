using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnim : MonoBehaviour
{

    SpriteRenderer sr;
    Rigidbody2D rb;
    public float moveSpeed = .5f;

    public Sprite lookright;
    public Sprite lookleft;
    public Sprite lookback;
    public Sprite lookfront;

    // Use this for initialization
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //if right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            sr.sprite = lookright;
            rb.AddForce(transform.right * 1f, ForceMode2D.Impulse);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
            {
                sr.sprite = lookleft;
                rb.AddForce(transform.right * -1f, ForceMode2D.Impulse);
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {

                rb.AddForce(transform.up * moveSpeed, ForceMode2D.Impulse);
            }
            else
            {
                sr.sprite = lookback;

            }
        }
    }
