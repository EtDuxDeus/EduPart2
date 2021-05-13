using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;

public class Serialization : MonoBehaviour
{
    private MyClassForJSon myExample = new MyClassForJSon();
    private string path = Application.streamingAssetsPath + "\\myExample";

    void Start()
    {
        myExample.myRank = 0;
        myExample.myMoney = 0;
        myExample.myName = "NoOne";
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myExample.myRank = 6;
            myExample.myMoney = 666;
            myExample.myName = "Me";
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(myExample);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            string json = JsonUtility.ToJson(myExample);

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
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                JsonUtility.FromJsonOverwrite(json, myExample);
                Debug.Log("Object is loaded");
            }
            else
            {
                Debug.Log("No File");
            }
        }
    }
}
