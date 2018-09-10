using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//[System.Serializable]
//public class GameDataEvent : UnityEvent<GameData>
//{

//}


[System.Serializable]
public class GameData {

    public Clock time;
    public int mental;
    public int money;

    public int grade;
    public int sociality;

}


