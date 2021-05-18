using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class Rotation_Quaternion : MonoBehaviour
    {
        private float _speed = -360f;


        private void Update()
        {
            RotateByQuaternion();
        }


        private void RotateByQuaternion()
        {
            transform.rotation *= Quaternion.AngleAxis(1 * _speed * Time.deltaTime, new Vector3(1, 1, 1));
        }
    }
}
