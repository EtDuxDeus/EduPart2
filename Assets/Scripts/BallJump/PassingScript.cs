using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassingScript : MonoBehaviour
{
    public int passingsThrough;
    // Start is called before the first frame update
    void Start()
    {
         passingsThrough = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        passingsThrough++;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
