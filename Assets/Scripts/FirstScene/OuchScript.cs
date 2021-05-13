using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuchScript : MonoBehaviour
{
    int i;
    void Start()
    {
        i = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        i++;
        Debug.Log("Ouch");
        if (i % 10 == 0)
        {
            Debug.Log("Screw you");
        }
    }
}
