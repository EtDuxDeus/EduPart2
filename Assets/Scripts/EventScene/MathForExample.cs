using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class MathForExample : MonoBehaviour
    {
        [SerializeField] private static double SumForExample;
        void Start()
        {
            SumForExample = 1;
        }

        void Update()
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

        public static void CalculateTheMath()
        {
            SumForExample = SumForExample + 1;
        }

        public static void WriteToLogTheAnswer()
        {
            Debug.Log(SumForExample);
        }
    }
}
