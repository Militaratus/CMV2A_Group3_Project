using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingItem : BaseItem
{
    int activeConstruction = 0;
    public int cpID;
    public GameObject[] constructions;
    private GameManager managerGame;

    // Use this for initialization
    void Start ()
    {
        // I must find the children! - Skeletor (Christmas Special)
        constructions = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            constructions[i] = transform.GetChild(i).gameObject;

            constructions[i].SetActive(false);
        }

        managerGame = GameObject.Find("__Managers").GetComponent<GameManager>();

        activeConstruction = managerGame.buildingsGM[cpID];
        constructions[activeConstruction].SetActive(true);            
    }

    // Use this for initialization
    public override void ActivateButton()
    {
        // Turn off old construction
        if (constructions[activeConstruction].GetComponent<BaseBuilding>() != null)
            constructions[activeConstruction].GetComponent<BaseBuilding>().KillMe();

        if (constructions[activeConstruction].GetComponent<FountainQuest>() != null)
            managerGame.FountainQuest(false);

        if (constructions[activeConstruction].GetComponent<HousingQuest>() != null)
            managerGame.HousingQuest(false);

        constructions[activeConstruction].SetActive(false);

        /*
        // Switch Construction
        activeConstruction++;

        if (activeConstruction >= transform.childCount)
            activeConstruction = 0;
        */

        // Build the chosen building
        activeConstruction = managerGame.chosenBuilding;
        managerGame.buildingsGM[cpID] = activeConstruction;

        constructions[activeConstruction].SetActive(true);
        constructions[activeConstruction].GetComponent<BaseBuilding>().BringMeToLife();

        if (constructions[activeConstruction].GetComponent<FountainQuest>() != null)
            managerGame.FountainQuest(true);

        if (constructions[activeConstruction].GetComponent<HousingQuest>() != null)
            managerGame.HousingQuest(true);
    }
}
