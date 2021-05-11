using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float hoverForce = 12f;
    private void OnTriggerStay(Collider other)
    {
        other.attachedRigidbody.AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
