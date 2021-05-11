using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePrefs : MonoBehaviour
{
    public static int numberForSave;


    void Start()
    {
        
        numberForSave = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            numberForSave++;
            Debug.Log("Number for save: "+ numberForSave);
        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
            PlayerPrefs.SetInt("Numerator",numberForSave);

            PlayerPrefs.Save();
            Debug.Log("Number is saved (" + numberForSave + ")");
        }
    }
}
