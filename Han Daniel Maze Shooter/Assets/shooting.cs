using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shooting : MonoBehaviour
{

    public Transform gunEnd;
    private Camera fpsCam;
    private LineRenderer laserLine;
    public Text winText;
  

    // Use this for initialization
    void Start()
    {
        fpsCam = GetComponentInChildren<Camera>();
        laserLine = gunEnd.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(.5f, .5f, 0f));
            RaycastHit hit;

            laserLine.enabled = true;
            laserLine.SetPosition(0, gunEnd.position);

            //Debug.DrawRay(rayOrigin, fpsCam.transform.forward);

            if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit))
            {
                //do something if we hit the cubes
                Debug.Log(hit.collider.tag);
                laserLine.SetPosition(1, hit.point);

                if (hit.collider.tag == "cube")
                {
                    // hit.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                    Destroy(hit.transform.gameObject);
                }
                else
                {
                    laserLine.SetPosition(1/2, fpsCam.transform.forward * 100f);
                }

            }
        }
        else
        {
            laserLine.enabled = false;
        }
    }
}
