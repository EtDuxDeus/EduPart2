using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventExample : MonoBehaviour
{
    public delegate void ExampleDelEventHandler();
    private static event ExampleDelEventHandler ExampleOfEvent;

    public static event ExampleDelEventHandler MyExampleOfEvent
    {
        add
        {
            ExampleOfEvent += value;
            Debug.Log("Some Logic On Ading");
        }
        remove
        {
            ExampleOfEvent -= value;
            Debug.Log("Some Logic On Removing");
        }
    }

    private void OnEnable()
    {
        MyExampleOfEvent += MathForExample.CalculateTheMath;
        MyExampleOfEvent += MathForExample.WriteToLogTheAnswer;
    }

    private void OnDisable()
    {
        MyExampleOfEvent -= MathForExample.CalculateTheMath;
        MyExampleOfEvent -= MathForExample.WriteToLogTheAnswer;
    }

    public static void ClearAllDelegatesFromEventHandler()
    {
        foreach (System.Delegate d in ExampleOfEvent.GetInvocationList())
        {
            ExampleOfEvent -= (ExampleDelEventHandler)d;
        }
    }

    private void SubToCalculateTheMath()
    {
        ExampleOfEvent += MathForExample.CalculateTheMath;
    }

    private void RemCalculateTheMath()
    {
        ExampleOfEvent -= MathForExample.CalculateTheMath;
    }

    private void SubToWriteToLogTheAnwer()
    {
        ExampleOfEvent += MathForExample.WriteToLogTheAnswer;
    }

    private void RemToWriteToLogTheAnwer()
    {
        ExampleOfEvent -= MathForExample.WriteToLogTheAnswer;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (ExampleOfEvent != null)
            {
                ExampleOfEvent.Invoke();
            }
            else
            {
                Debug.Log("No subscribers");
            }
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            SubToCalculateTheMath();
            SubToWriteToLogTheAnwer();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            RemCalculateTheMath();
            RemToWriteToLogTheAnwer();
        }
    }
}
