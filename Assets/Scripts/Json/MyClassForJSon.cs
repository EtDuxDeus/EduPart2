using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MyClassForJSon
{
    public int myRank;
    public string myName;
    public int myMoney;

    public override string ToString()
    {
        return myName + " " + myRank + " " + myMoney;
    }
}
