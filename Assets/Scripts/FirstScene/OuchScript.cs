using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuchScript : MonoBehaviour
{
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
