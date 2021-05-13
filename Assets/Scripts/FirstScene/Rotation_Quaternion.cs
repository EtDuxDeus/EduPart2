using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Quaternion : MonoBehaviour
{

    public float speed = -360f;

    void Update()
    {
        RotateByQuaternion();
    }

    private void RotateByQuaternion()
    {

        transform.rotation *= Quaternion.AngleAxis(1 * speed * Time.deltaTime, new Vector3(1, 1, 1));

    }
}
