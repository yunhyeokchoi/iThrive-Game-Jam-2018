using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyEvent : MonoBehaviour {

    public string eventName;

    float ex;

    //public float Ex
    //{
    //    get {
    //        return ex;
    //    }
    //    set {
    //        if (value < 0)
    //        {
    //        }
    //    }
    //}


    public float moneyRequired;
    public Clock timeRequired;
    public float mentalRequired;
    
    public float moneyEarned;
    public float mentalEarned;
    public float socialityEarned;
    
    public bool Validate(float money, Clock time, float mental)
    {
        if (moneyRequired > money || 
            24 - time.Hour < timeRequired.Hour || 
            mentalRequired > mental)
        {
            return false;
        }

        return true;
    }
}
