using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassingScript : MonoBehaviour
{
    [SerializeField] private int passingsThrough;

    void Start()
    {
        passingsThrough = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        passingsThrough++;
    }

}
