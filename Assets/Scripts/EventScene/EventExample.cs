using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class EventExample : MonoBehaviour
    {
        public delegate void SubscriberMethodHandler();

        private static event SubscriberMethodHandler SubscriberCaller;


        private void Update()
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
                SubscribeToIncreaseIteratorOfMethodCall();
                SubscribeToWriteToLogTheAnwer();
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                ClearAllDelegatesFromEventHandler();
            }
        }


        private void InvokeTheEvent()
        {
            if (SubscriberCaller != null)
            {
                SubscriberCaller.Invoke();
            }
            else
            {
                Debug.Log("No subscribers");
            }
        }


        private void OnEnable()
        {
            SubscribeToIncreaseIteratorOfMethodCall();
            SubscribeToWriteToLogTheAnwer();
        }


        private void OnDisable()
        {
            RemoveIncreaseIteratorOfMethodCall();
            RemoveToWriteToLogTheAnwer();
        }


        public static event SubscriberMethodHandler MySubscriberCaller
        {
            add
            {
                SubscriberCaller += value;
                Debug.Log("Some Logic On Ading");
            }
            remove
            {
                SubscriberCaller -= value;
                Debug.Log("Some Logic On Removing");
            }
        }


        public static void ClearAllDelegatesFromEventHandler()
        {
            foreach (System.Delegate d in SubscriberCaller.GetInvocationList())
            {
                SubscriberCaller -= (SubscriberMethodHandler)d;
            }
        }


        private void SubscribeToIncreaseIteratorOfMethodCall()
        {
            SubscriberCaller += SubscriberForEvent.IncreaseIteratorOfMethodCall;
        }


        private void RemoveIncreaseIteratorOfMethodCall()
        {
            SubscriberCaller -= SubscriberForEvent.IncreaseIteratorOfMethodCall;
        }


        private void SubscribeToWriteToLogTheAnwer()
        {
            SubscriberCaller += SubscriberForEvent.WriteIteratorToLog;
        }


        private void RemoveToWriteToLogTheAnwer()
        {
            SubscriberCaller -= SubscriberForEvent.WriteIteratorToLog;
        }
    }
}
