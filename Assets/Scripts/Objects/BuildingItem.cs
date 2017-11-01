using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingItem : BaseItem
{
    int activeConstruction = 0;
    public GameObject[] constructions;

    // Use this for initialization
    void Start ()
    {
        // I must find the children! - Skeletor (Christmas Special)
        constructions = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            constructions[i] = transform.GetChild(i).gameObject;

            if (i != 0)
                constructions[i].SetActive(false);
        }
    }

    // Use this for initialization
    public override void ActivateButton()
    {
        // Turn off old construction
        constructions[activeConstruction].SetActive(false);

        // Switch Construction
        activeConstruction++;

        if (activeConstruction >= transform.childCount)
            activeConstruction = 0;

        constructions[activeConstruction].SetActive(true);
    }
}
