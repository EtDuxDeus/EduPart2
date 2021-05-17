using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class Rotation_Euler : MonoBehaviour
    {

        private float speed = 360f;


        void Update()
        {
            RotateByEuler();
        }

        private void RotateByEuler()
        {
            transform.eulerAngles += new Vector3(1, 1, 1) * Time.deltaTime * speed;
        }
    }
}
