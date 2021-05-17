using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;

namespace Tools
{
    public class Serialization : MonoBehaviour
    {
        private MyClassForJSon myEntity;
        private string path;

        void Start()
        {
            myEntity = new MyClassForJSon();
            path = Application.streamingAssetsPath + "\\myEntity";
            myEntity.myRank = 0;
            myEntity.myMoney = 0;
            myEntity.myName = "NoOne";
        }


        void Update()
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
                myEntity.myRank = 6;
                myEntity.myMoney = 666;
                myEntity.myName = "Me";
            }
        }

        private void ShowEntityInfo()
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                Debug.Log(myEntity);
            }
        }

        private void SaveEntityToJson()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                string json = JsonUtility.ToJson(myEntity);

                if (File.Exists(path))
                {
                    File.WriteAllText(path, json);
                    Debug.Log("Saved");
                }
                else
                {
                    File.Create(path);
                    Debug.Log("JsonFile Created");
                }

            }
        }

        private void LoadEntityFromJson()
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    JsonUtility.FromJsonOverwrite(json, myEntity);
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
