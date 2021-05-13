using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceLoadExample : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPoint = transform.position + new Vector3(0f, 2f, 0f);

            Instantiate(Resources.Load<GameObject>("Sphere"), spawnPoint, transform.rotation);
        }
    }
}
