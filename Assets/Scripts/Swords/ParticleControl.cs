using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class ParticleControl : MonoBehaviour
    {
        private ParticleSystem swordParticles;

        private void Awake()
        {
            swordParticles = GetComponent<ParticleSystem>();
        }

        void Update()
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
            if (swordParticles.isPlaying)
            {
                swordParticles.Stop();
            }
            else
            {
                swordParticles.Play();
            }
        }
    }
}
