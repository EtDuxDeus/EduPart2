using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace Tools
{
    public class ControllerScript : MonoBehaviour
    {
        public float distance = 10;
        public float pushForce = 200;
        public static int hitNumber = 0;
        public float TurnPower = 50f;

        private Rigidbody rigBod;
        private RaycastHit hit;

        void Start()
        {
            rigBod = GetComponent<Rigidbody>();
        }



        void Update()
        {
            Move();
            if (Input.GetButtonDown("Jump"))
            {
                Shoot();
            }


        }

        private void Move()
        {
            float h = Input.GetAxis("Horizontal") * TurnPower * Time.deltaTime;
            float v = Input.GetAxis("Vertical") * TurnPower * Time.deltaTime;

            rigBod.AddTorque(transform.up * h);
            rigBod.AddTorque(transform.right * v);
        }

        private void Shoot()
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
}
