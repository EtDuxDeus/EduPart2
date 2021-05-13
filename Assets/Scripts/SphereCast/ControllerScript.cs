using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ControllerScript : MonoBehaviour
{
    public float distance = 10;
    public float pushForce = 200;
    public static int hitNumber = 0;

    Rigidbody rigBod;
    RaycastHit hit;

    void Start()
    {
        rigBod = GetComponent<Rigidbody>();
    }
    public float TurnPower = 50f;
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Shoot();
        }
        float h = Input.GetAxis("Horizontal") * TurnPower * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * TurnPower * Time.deltaTime;

        rigBod.AddTorque(transform.up * h);
        rigBod.AddTorque(transform.right * v);

    }

    public void Shoot()
    {
        if (Physics.SphereCast(transform.position, 1f, transform.forward, out hit, distance))
        {
            hit.collider.GetComponent<GameObject>();

            hit.rigidbody.AddForce(-hit.normal * pushForce);

            hitNumber++;
        }
        else
        {
            Debug.Log("Missed");
        }
    }


}
