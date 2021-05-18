using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class TorqueScript : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private float _turnPower = 50f;


        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }


        private void Update()
        {
            RotateByTorque();
        }


        private void RotateByTorque()
        {
            float h = Input.GetAxis("Horizontal") * _turnPower * Time.deltaTime;
            float v = Input.GetAxis("Vertical") * _turnPower * Time.deltaTime;

            _rigidbody.AddTorque(transform.up * h);
            _rigidbody.AddTorque(transform.right * v);
        }
    }
}
