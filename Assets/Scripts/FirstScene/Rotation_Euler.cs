using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Euler : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed  = 360f;

    void Start()
    {

       
    }
    // Update is called once per frame
    void Update()
    {
        RotateByEuler();
    }

    void RotateByEuler()
    {
        
        transform.eulerAngles += new Vector3(1, 1, 1) * Time.deltaTime * speed;
    }
}
