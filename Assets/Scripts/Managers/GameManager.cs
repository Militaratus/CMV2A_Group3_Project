using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Resources
    public float money = 7500000;
    public float power = 1000;
    public float water = 1000;

    // People Happiness
    public float students = 50;
    public float couples = 50;
    public float families = 50;
    public float ancients = 50;
    public float hippies = 50;

    // Buildings
    public int chosenBuilding;
    public int[] buildingsGM;

    // Quests
    public bool questFountain;
    public bool questHousing;
    public int questHousingRequirement = 0;

    private void Start()
    {
        buildingsGM = new int[10];
        DontDestroyOnLoad(gameObject);
    }

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
    }

    public void AffectCouples(int affection)
    {
        couples = couples - affection;
    }

    public void AffectFamilies(int affection)
    {
        families = families - affection;
    }

    public void AffectAncients(int affection)
    {
        ancients = ancients - affection;
    }

    public void AffectHippies(int affection)
    {
        hippies = hippies - affection;
    }

    public void FountainQuest(bool complete)
    {
        questFountain = complete;
    }

    public void HousingQuest(bool added)
    {
        if (added)
            questHousingRequirement++;
        else
            questHousingRequirement--;

        if (questHousingRequirement >= 3)
            questHousing = true;
        else
            questHousing = false;
    }
}
