using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class SubscriberForEvent : MonoBehaviour
    {
        private static int _iteratorOfMethodCalls;


        private void Start()
        {
            _iteratorOfMethodCalls = 0;
        }


        private void Update()
        {
            EraseAllDelegateFromEvent();
        }


        private void EraseAllDelegateFromEvent()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                EventExample.ClearAllDelegatesFromEventHandler();
            }
        }


        public static void IncreaseIteratorOfMethodCall()
        {
            _iteratorOfMethodCalls++;
        }


        public static void WriteIteratorToLog()
        {
            Debug.Log(_iteratorOfMethodCalls);
        }
    }
}
