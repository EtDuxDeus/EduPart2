using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class PassingScript : MonoBehaviour
    {
        [SerializeField] private int _passingsThrough;


        private void Start()
        {
            _passingsThrough = 0;
        }


        private void OnTriggerEnter(Collider other)
        {
            _passingsThrough++;
        }

    }
}
