using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorqueScript : MonoBehaviour
{
    Rigidbody rigBod;
    // Start is called before the first frame update
    void Start()
    {
       rigBod =  GetComponent<Rigidbody>();
    }
    public float amount = 50f;
    void FixedUpdate()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * amount * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * amount * Time.deltaTime;

        rigBod.AddTorque(transform.up * h);
        rigBod.AddTorque(transform.right * v);
    }

  



}
