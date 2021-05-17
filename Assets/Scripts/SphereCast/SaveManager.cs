using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace Tools
{
    public class SaveManager : MonoBehaviour
    {
        private string path;
        private void Awake()
        {
            path = Application.persistentDataPath + "\\save.txt";
        }
        void Start()
        {
            LoadFromFile();
        }

        void Update()
        {
            SaveToFile();
        }

        private void LoadFromFile()
        {
            if (File.Exists(path))
            {
                ControllerScript.hitNumber = Convert.ToInt32(File.ReadAllText(path));
            }
            else
            {
                File.Create(path);
            }
        }

        private void SaveToFile()
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                HitSave();
            }
        }

        public void HitSave()
        {
            if (File.Exists(path))
            {
                File.WriteAllText(path, Convert.ToString(ControllerScript.hitNumber));
            }
            else
            {
                File.Create(path);

                File.WriteAllText(path, Convert.ToString(ControllerScript.hitNumber));
            }
        }

    }
}
