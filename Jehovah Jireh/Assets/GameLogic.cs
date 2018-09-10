using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

    public int day;
    public Clock time;
    public int mental;
    public int money;
    public int grade;
    public int sociality;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IncreaseMetal(int amount)
    {
        mental += amount;
    }
    public void IncreaseMoney(int amount)
    {
        money += amount;
    }
    public void IncreaseGrade(int amount)
    {
        grade += amount;
    }
    public void IncreaseSociality(int amount)
    {
        sociality += amount;
    }

    public string GradeToString(int grade)
    {
        if (grade >= 97)
        {
            return "A+";
        }
        else if (grade >= 93)
        {
            return "A";
        }
        else if (grade >= 90)
        {
            return "A-";
        }

        else if (grade >= 87)
        {
            return "B+";
        }
        else if (grade >= 83)
        {
            return "B";
        }
        else if (grade >= 80)
        {
            return "B-";
        }

        else if (grade >= 77)
        {
            return "C+";
        }
        else if (grade >= 73)
        {
            return "C";
        }
        else if (grade >= 70)
        {
            return "C-";
        }

        else if (grade >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
    
}
