using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class NormalizedMovingScript : MonoBehaviour
    {
        private float speed = 100f;

        void Update()
        {
            MoveByNormalizedVector();
        }

        private void MoveByNormalizedVector()
        {
            float deltaTimeSpeed = speed * Time.deltaTime;

            transform.position += transform.forward * deltaTimeSpeed;
            transform.rotation *= Quaternion.AngleAxis(1 * deltaTimeSpeed, new Vector3(0, 1, 0));
        }

    }
}
