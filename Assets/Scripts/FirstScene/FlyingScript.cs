using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class FlyingScript : MonoBehaviour
    {

        private float hoverForce = 12f;
        private void OnTriggerStay(Collider other)
        {
            MakeObjectFly(other);
        }

        private void MakeObjectFly(Collider other)
        {
            other.attachedRigidbody.AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);
        }
    }
}
