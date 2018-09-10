using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Clock
{
    uint hour;

    public uint Hour
    {
        get { return hour; }
        set
        {
            if (value >= 24)
            {
                value = 0;
            }
            else
            {
                hour = value;
            }
        }
    }
}