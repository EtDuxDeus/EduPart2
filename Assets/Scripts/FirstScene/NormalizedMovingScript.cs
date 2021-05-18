using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class NormalizedMovingScript : MonoBehaviour
    {
        private float _speed = 100f;


        private void Update()
        {
            MoveByNormalizedVector();
        }


        private void MoveByNormalizedVector()
        {
            float deltaTimeSpeed = _speed * Time.deltaTime;

            transform.position += transform.forward * deltaTimeSpeed;
            transform.rotation *= Quaternion.AngleAxis(1 * deltaTimeSpeed, new Vector3(0, 1, 0));
        }

    }
}
