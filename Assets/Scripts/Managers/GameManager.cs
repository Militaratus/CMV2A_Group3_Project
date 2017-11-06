using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Resources
    public int money = 7500000;
    public int power = 1000;
    public int water = 1000;

    // People Happiness
    public float students = 50;
    public float couples = 50;
    public float families = 50;
    public float ancients = 50;
    public float hippies = 50;

    public void SpendMoney(int spentMoney)
    {
        money = money - spentMoney;
    }

    public void SpendPower(int spentPower)
    {
        power = power - spentPower;
    }

    public void SpendWater(int spentWater)
    {
        water = water - spentWater;
    }

    public void AffectStudents(int affection)
    {
        students = students - affection;

        if (students < 0)
            students = 0;
    }

    public void AffectCouples(int affection)
    {
        couples = couples - affection;

        if (couples < 0)
            couples = 0;
    }

    public void AffectFamilies(int affection)
    {
        families = families - affection;

        if (families < 0)
            families = 0;
    }

    public void AffectAncients(int affection)
    {
        ancients = ancients - affection;

        if (ancients < 0)
            ancients = 0;
    }

    public void AffectHippies(int affection)
    {
        hippies = hippies - affection;

        if (hippies < 0)
            hippies = 0;
    }
}
