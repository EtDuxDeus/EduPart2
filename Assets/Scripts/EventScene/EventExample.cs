using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventExample : MonoBehaviour
{
    public delegate void exampleDel();
    private static event exampleDel Eventer;

    public static event exampleDel MyEventer
    {
        add
        {
            Eventer += value;
            Debug.Log("Some Logic On Ading");
        }
        remove
        {
            Eventer -= value;
            Debug.Log("Some Logicn On Removing");
        }
    }
    
    
    void Start()
    {
        MyEventer += MathForExample.CalculateTheMath;
        MyEventer += MathForExample.WriteToLogTheAnswer;
        Eventer();
        MyEventer -= MathForExample.CalculateTheMath;
        MyEventer -= MathForExample.WriteToLogTheAnswer;
    }

    public static void ClearAllDelegatesFromEventHandler()
    {
        foreach(System.Delegate d in Eventer.GetInvocationList())
        {
            Eventer -= (exampleDel)d;
        }
    }

    private void SubToCalculateTheMath()
    {
        Eventer += MathForExample.CalculateTheMath;
    }

    private void RemCalculateTheMath()
    {
        Eventer -= MathForExample.CalculateTheMath;
    }

    private void SubToWriteToLogTheAnwer()
    {
        Eventer += MathForExample.WriteToLogTheAnswer;
    }

    private void RemToWriteToLogTheAnwer()
    {
        Eventer -= MathForExample.WriteToLogTheAnswer;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(Eventer != null)
            {
                Eventer.Invoke();
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
