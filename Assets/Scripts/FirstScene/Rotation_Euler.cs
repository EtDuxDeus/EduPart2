using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Euler : MonoBehaviour
{

    public float speed = 360f;


    void Update()
    {
        RotateByEuler();
    }

    private void RotateByEuler()
    {
        transform.eulerAngles += new Vector3(1, 1, 1) * Time.deltaTime * speed;
    }
}
