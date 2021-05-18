using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class LoadPrefs : MonoBehaviour
    {
        private int _NumberToShowLoadingFromPrefs;


        private void Update()
        {
            SaveDataToPlayerPrefs();
            EraseDataFromPlayerPrefs();
        }


        private void SaveDataToPlayerPrefs()
        {
            if (Input.GetKeyDown(KeyCode.F9))
            {
                if (PlayerPrefs.HasKey("Numerator"))
                {
                    _NumberToShowLoadingFromPrefs = PlayerPrefs.GetInt("Numerator");
                    SavePrefs.NumberForSave = _NumberToShowLoadingFromPrefs;
                }
                else
                {
                    _NumberToShowLoadingFromPrefs = 0;
                }
                Debug.Log("Number is loaded: " + _NumberToShowLoadingFromPrefs);
            }
        }


        private void EraseDataFromPlayerPrefs()
        {
            if (Input.GetKeyDown(KeyCode.F10))
            {
                PlayerPrefs.DeleteAll();
                SavePrefs.NumberForSave = 0;
                Debug.Log("All data is erased");
            }
        }
    }
}
