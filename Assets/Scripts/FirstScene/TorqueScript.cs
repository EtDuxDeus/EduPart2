using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class TorqueScript : MonoBehaviour
    {
        private Rigidbody RigBod;
        private float TurnPower = 50f;

        void Start()
        {
            RigBod = GetComponent<Rigidbody>();
        }


        void Update()
        {
            RotateByTorque();
        }

        private void RotateByTorque()
        {
            float h = Input.GetAxis("Horizontal") * TurnPower * Time.deltaTime;
            float v = Input.GetAxis("Vertical") * TurnPower * Time.deltaTime;

            RigBod.AddTorque(transform.up * h);
            RigBod.AddTorque(transform.right * v);
        }

    }
}
