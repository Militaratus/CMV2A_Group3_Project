using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCP : MonoBehaviour
{
    // Internal stuff
    bool amActive = false;
    bool amActivated = false;
    int activeConstruction = 0;
    public GameObject[] constructions;
    public Material[] startingMaterials;

    [Tooltip("Insert a Material here to be used to highlight that this gameObject is selected.")]
    public Material selectMaterial;

    // Use this for initialization
    void Start()
    {
        // I must find the children! - Skeletor (Christmas Special)
        constructions = new GameObject[transform.childCount];
        startingMaterials = new Material[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            constructions[i] = transform.GetChild(i).gameObject;
            startingMaterials[i] = constructions[i].transform.GetChild(0).GetComponent<Renderer>().material;

            if (i != 0)
                constructions[i].SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetAxis("Fire1") == 0)
        {
            amActivated = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (amActive)
        {
            amActive = false;
        }
        else
        {
            constructions[activeConstruction].transform.GetChild(0).GetComponent<Renderer>().material = startingMaterials[activeConstruction];
        }
    }

    public void ObjectHit()
    {
        amActive = true;
        constructions[activeConstruction].transform.GetChild(0).GetComponent<Renderer>().material = selectMaterial;

        if (Input.GetAxis("Fire1") >= 1 && !amActivated)
        {
            amActivated = true;
            ObjectAction();
        }
    }

    public virtual void ObjectAction()
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
