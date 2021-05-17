using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class SavePrefs : MonoBehaviour
    {
        public static int numberForSave;


        void Start()
        {
            numberForSave = 0;
        }

        void Update()
        {
            IncreaseNumber();
            SaveToPlayerPrefs();
        }

        private void IncreaseNumber()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                numberForSave++;
                ShowNumberToLog();
            }
        }
        private void ShowNumberToLog()
        {
            Debug.Log("Number for save: " + numberForSave);
        }

        private void SaveToPlayerPrefs()
        {
            if (Input.GetKeyDown(KeyCode.F5))
            {
                PlayerPrefs.SetInt("Numerator", numberForSave);

                PlayerPrefs.Save();
                ShowSavingInfo();
            }
        }
        private void ShowSavingInfo()
        {
            Debug.Log("Number is saved (" + numberForSave + ")");
        }
    }
}
