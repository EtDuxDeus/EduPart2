using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JumpCounterScript : MonoBehaviour
{

    public GameObject ground;
    public int CountOfBallJumps;
    private float distanceToTheGround;
    public TextMeshProUGUI HUDJumpsAndDistanceToTheFloor;
    void Start()
    {
        CountOfBallJumps = 0;
    }


    private void OnCollisionEnter(Collision collision)
    {
        CountOfBallJumps++;
    }


    void Update()
    {
        HUDJumpsAndDistanceToTheFloor.text = "Distance to the ground: \n" + Mathf.Abs(transform.position.y - ground.transform.position.y) + "\n jumps: " + CountOfBallJumps;
    }
}
