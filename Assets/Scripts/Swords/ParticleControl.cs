using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class ParticleControl : MonoBehaviour
    {
        private ParticleSystem _swordParticles;


        private void Awake()
        {
            _swordParticles = GetComponent<ParticleSystem>();
        }


        private void Update()
        {
            ControlParticleSystem();
        }


        private void ControlParticleSystem()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SwitchParticleState();
            }
        }


        private void SwitchParticleState()
        {
            if (_swordParticles.isPlaying)
            {
                _swordParticles.Stop();
            }
            else
            {
                _swordParticles.Play();
            }
        }
    }
}
