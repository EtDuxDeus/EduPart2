using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathForExample : MonoBehaviour
{
    public static double i;
    void Start()
    {
        
        i = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            EventExample.ClearAllDelegatesFromEventHandler();
        }
    }

    public static void CalculateTheMath()
    {
        i = i + 1;
    }

    public static void WriteToLogTheAnswer()
    {
        Debug.Log(i);
    }
}
