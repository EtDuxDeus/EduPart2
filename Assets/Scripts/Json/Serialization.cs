using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;

namespace Tools
{
    public class Serialization : MonoBehaviour
    {
        private MyClassForJSon _myEntity;
        private string _path;


        private void Start()
        {
            _myEntity = new MyClassForJSon();
            _path = Application.streamingAssetsPath + "\\myEntity";
            _myEntity.myRank = 0;
            _myEntity.myMoney = 0;
            _myEntity.myName = "NoOne";
        }


        private void Update()
        {
            FillTheFieldsOfClass();
            ShowEntityInfo();
            SaveEntityToJson();
            LoadEntityFromJson();
        }


        private void FillTheFieldsOfClass()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _myEntity.myRank = 6;
                _myEntity.myMoney = 666;
                _myEntity.myName = "Me";
            }
        }


        private void ShowEntityInfo()
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                Debug.Log(_myEntity);
            }
        }


        private void SaveEntityToJson()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                string json = JsonUtility.ToJson(_myEntity);

                if (File.Exists(_path))
                {
                    File.WriteAllText(_path, json);
                    Debug.Log("Saved");
                }
                else
                {
                    File.Create(_path);
                    Debug.Log("JsonFile Created");
                }

            }
        }


        private void LoadEntityFromJson()
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                if (File.Exists(_path))
                {
                    string json = File.ReadAllText(_path);
                    JsonUtility.FromJsonOverwrite(json, _myEntity);
                    Debug.Log("Object is loaded");
                }
                else
                {
                    Debug.Log("No File");
                }
            }
        }
    }
}
