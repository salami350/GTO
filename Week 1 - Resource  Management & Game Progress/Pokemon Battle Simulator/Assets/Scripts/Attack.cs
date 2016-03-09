﻿using UnityEngine;
using System.Collections;

public class Attack
{
    private string name;
    private string type;
    private int power;
    private int accuracy;

    public Attack(string name, string type, int power, int accuracy)
    {
        this.name = name;
        this.type = type;
        this.power = power;
        this.accuracy = accuracy;
    }

    public string getName()
    {
        return name;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public string getType()
    {
        return type;
    }

    public void setType(string type)
    {
        this.type = type;
    }

    public int getPower()
    {
        return power;
    }

    public void setPower(int power)
    {
        this.power = power;
    }

    public int getAccuracy()
    {
        return accuracy;
    }

    public void setAccuracy(int accuracy)
    {
        this.accuracy = accuracy;
    }
}