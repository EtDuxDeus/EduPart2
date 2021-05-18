using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class SavePrefs : MonoBehaviour
    {
        public static int NumberForSave;


        private void Start()
        {
            NumberForSave = 0;
        }


        private void Update()
        {
            IncreaseNumber();
            SaveToPlayerPrefs();
        }


        private void IncreaseNumber()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                NumberForSave++;
                ShowNumberToLog();
            }
        }


        private void ShowNumberToLog()
        {
            Debug.Log("Number for save: " + NumberForSave);
        }


        private void SaveToPlayerPrefs()
        {
            if (Input.GetKeyDown(KeyCode.F5))
            {
                PlayerPrefs.SetInt("Numerator", NumberForSave);

                PlayerPrefs.Save();
                ShowSavingInfo();
            }
        }


        private void ShowSavingInfo()
        {
            Debug.Log("Number is saved (" + NumberForSave + ")");
        }
    }
}
