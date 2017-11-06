using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderSelect : MonoBehaviour
{
    int activeConstruction = 0;
    public GameObject[] constructions;

    // Use this for initialization
    void Start()
    {
        // I must find the children! - Skeletor (Christmas Special)
        constructions = new GameObject[transform.GetChild(1).transform.childCount];
        for (int i = 0; i < transform.GetChild(1).transform.childCount; i++)
        {
            constructions[i] = transform.GetChild(1).transform.GetChild(i).gameObject;
            constructions[i].SetActive(false);
        }
        constructions[0].SetActive(true);
    }

    public void NextBuilding()
    {
        // Turn off old construction
        constructions[activeConstruction].SetActive(false);

        // Switch Construction
        activeConstruction++;

        if (activeConstruction > transform.GetChild(1).transform.childCount - 1)
            activeConstruction = 0;

        Debug.Log(activeConstruction);

        constructions[activeConstruction].SetActive(true);
    }

    public void PrevBuilding()
    {
        // Turn off old construction
        constructions[activeConstruction].SetActive(false);

        // Switch Construction
        activeConstruction--;

        if (activeConstruction < 0)
            activeConstruction = transform.GetChild(1).transform.childCount - 1;

        Debug.Log(activeConstruction);

        constructions[activeConstruction].SetActive(true);
    }
}
