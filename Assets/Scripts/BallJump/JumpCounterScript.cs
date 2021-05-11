using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JumpCounterScript : MonoBehaviour
{
    public int jumps;
    public GameObject ground;
    public float distanceToTheGround;
    public TextMeshProUGUI Canvas;
    // Start is called before the first frame update
    void Start()
    {
        jumps = 0;
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        jumps++;
    }

    // Update is called once per frame
    void Update()
    {
        
        Canvas.text = "Distance to the ground: \n" + Mathf.Abs(transform.position.y - ground.transform.position.y) + "\n jumps: " + jumps;
        
       
    }
}
