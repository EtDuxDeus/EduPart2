using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalizedMovingScript : MonoBehaviour
{
    float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveByNormalizedVector();
    }

    public void MoveByNormalizedVector()
    {
        float deltaTimeSpeed = speed * Time.deltaTime;
        transform.position += transform.forward*deltaTimeSpeed;
        transform.rotation *= Quaternion.AngleAxis(1*deltaTimeSpeed, new Vector3(0, 1, 0));
        
    }
}
