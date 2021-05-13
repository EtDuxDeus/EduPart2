using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathForExample : MonoBehaviour
{
    public static double SumForExample;
    void Start()
    {
        SumForExample = 1;
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
        SumForExample = SumForExample + 1;
    }

    public static void WriteToLogTheAnswer()
    {
        Debug.Log(SumForExample);
    }
}
