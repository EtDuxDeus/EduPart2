using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorqueScript : MonoBehaviour
{
    private Rigidbody RigBod;
    void Start()
    {
        RigBod = GetComponent<Rigidbody>();
    }
    public float TurnPower = 50f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal") * TurnPower * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * TurnPower * Time.deltaTime;

        RigBod.AddTorque(transform.up * h);
        RigBod.AddTorque(transform.right * v);
    }





}
