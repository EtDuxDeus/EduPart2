using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class OuchScript : MonoBehaviour
    {

        private void OnTriggerEnter(Collider other)
        {
            WriteToLog();
        }

        private void WriteToLog()
        {
            Debug.Log("Ouch");
        }
    }
}
