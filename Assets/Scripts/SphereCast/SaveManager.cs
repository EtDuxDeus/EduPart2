using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace Tools
{
    public class SaveManager : MonoBehaviour
    {
        private string _path;


        private void Awake()
        {
            _path = Application.persistentDataPath + "\\save.txt";
        }


        private void Start()
        {
            LoadFromFile();
        }

        private void Update()
        {
            SaveToFile();
        }

        private void LoadFromFile()
        {
            if (File.Exists(_path))
            {
                ControllerScript.hitNumber = Convert.ToInt32(File.ReadAllText(_path));
            }
            else
            {
                CreateFile();
            }
        }


        private void CreateFile()
        {
            File.Create(_path);
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
            if (File.Exists(_path))
            {
                File.WriteAllText(_path, Convert.ToString(ControllerScript.hitNumber));
            }
            else
            {
                CreateFile();
                HitSave();
            }
        }

    }
}
