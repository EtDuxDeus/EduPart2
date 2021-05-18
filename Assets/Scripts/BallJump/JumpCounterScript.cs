using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace Tools
{
    public class JumpCounterScript : MonoBehaviour
    {
        public GameObject ground;
        public TextMeshProUGUI HUDJumpsAndDistanceToTheFloor;

        [SerializeField] private float _distanceToTheGround;
        [SerializeField] private int _CountOfBallJumps;


        private void Start()
        {
            _CountOfBallJumps = 0;
        }


        private void OnCollisionEnter(Collision collision)
        {
            _CountOfBallJumps++;
        }


        private void Update()
        {
            ShowInfo();
        }


        private void ShowInfo()
        {
            HUDJumpsAndDistanceToTheFloor.text = "Distance to the ground: \n" + Mathf.Abs(transform.position.y - ground.transform.position.y)
                + "\n jumps: " + _CountOfBallJumps;
        }

    }
}
