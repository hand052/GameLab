using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class shooting : MonoBehaviour
{
    public GameObject laser;
    public Transform laserPoint;




    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var Laser = (GameObject)Instantiate(
            laser,
            laserPoint.position,
            laserPoint.rotation);

        // Add velocity to the bullet
        Laser.GetComponent<Rigidbody2D>().velocity = Laser.transform.up * 6;

        // Destroy the bullet after 2 seconds


        Destroy(Laser, 2.0f);
    }




    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}