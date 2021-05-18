using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class Rotation_Euler : MonoBehaviour
    {
        private float _speed = 360f;


        private void Update()
        {
            RotateByEuler();
        }


        private void RotateByEuler()
        {
            transform.eulerAngles += new Vector3(1, 1, 1) * Time.deltaTime * _speed;
        }
    }
}
