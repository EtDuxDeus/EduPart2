using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class EventExample : MonoBehaviour
    {
        public delegate void MathMethodHandler();
        private static event MathMethodHandler MathCaller;

        void Update()
        {
            ControlTheEventSystem();
        }

        private void ControlTheEventSystem()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                InvokeTheEvent();
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                SubToCalculateTheMath();
                SubToWriteToLogTheAnwer();
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                ClearAllDelegatesFromEventHandler();
            }
        }
        private void InvokeTheEvent()
        {
            if (MathCaller != null)
            {
                MathCaller.Invoke();
            }
            else
            {
                Debug.Log("No subscribers");
            }
        }



        private void OnEnable()
        {
            SubToCalculateTheMath();
            SubToWriteToLogTheAnwer();
        }

        private void OnDisable()
        {
            RemCalculateTheMath();
            RemToWriteToLogTheAnwer();
        }

        public static event MathMethodHandler MyMathCaller
        {
            add
            {
                MathCaller += value;
                Debug.Log("Some Logic On Ading");
            }
            remove
            {
                MathCaller -= value;
                Debug.Log("Some Logic On Removing");
            }
        }

        public static void ClearAllDelegatesFromEventHandler()
        {
            foreach (System.Delegate d in MathCaller.GetInvocationList())
            {
                MathCaller -= (MathMethodHandler)d;
            }
        }

        private void SubToCalculateTheMath()
        {
            MathCaller += MathForExample.CalculateTheMath;
        }

        private void RemCalculateTheMath()
        {
            MathCaller -= MathForExample.CalculateTheMath;
        }

        private void SubToWriteToLogTheAnwer()
        {
            MathCaller += MathForExample.WriteToLogTheAnswer;
        }

        private void RemToWriteToLogTheAnwer()
        {
            MathCaller -= MathForExample.WriteToLogTheAnswer;
        }



    }
}
