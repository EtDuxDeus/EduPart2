using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPrefs : MonoBehaviour
{
    public int importantNumber;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F9))
        {
            if (PlayerPrefs.HasKey("Numerator"))
            {
                importantNumber = PlayerPrefs.GetInt("Numerator");
                SavePrefs.numberForSave = importantNumber;
            }
            else
            {
                importantNumber = 0;
            }
            Debug.Log("Number is loaded: " + importantNumber);
        }

        if (Input.GetKeyDown(KeyCode.F10))
        {
            PlayerPrefs.DeleteAll();
            SavePrefs.numberForSave = 0;
            Debug.Log("All data is erased");
        }
    }
}
