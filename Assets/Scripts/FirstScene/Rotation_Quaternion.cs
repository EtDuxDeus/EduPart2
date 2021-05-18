using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class Rotation_Quaternion : MonoBehaviour
    {
        private float _speed = -360f;
        [SerializeField] private double _numberOfRotations = 0;
        [SerializeField] private double _RPM = 0;
        private bool positiveSign = false;

        private void Update()
        {
            RotateByQuaternion();
            RPMShowInfo();
        }


        private void RotateByQuaternion()
        {
            transform.rotation *= Quaternion.AngleAxis(1 * _speed * Time.deltaTime, new Vector3(0, 1, 0));
        }


        private void RPMShowInfo()
        {
            if (transform.rotation.y > 0 & positiveSign)
            {
                _numberOfRotations += 1;
                positiveSign = !positiveSign;
            }
            if (transform.rotation.y < 0 & !positiveSign)
            {
                _numberOfRotations += 1;
                positiveSign = !positiveSign;
            }
            _RPM = _numberOfRotations / (Time.realtimeSinceStartup / 60);
        }
    }
}
