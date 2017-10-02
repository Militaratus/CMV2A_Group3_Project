using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseObject : MonoBehaviour
{
    // Internal stuff
    Material startingMaterial;
    Renderer rend;
    bool amActive = false;

    [Tooltip("Insert a Material here to be used to highlight that this gameObject is selected.")]
    public Material selectMaterial;

    [Tooltip("Insert a GameObject here to appear whenever the player presses the Action button.")]
    public GameObject activatingObject;

	// Use this for initialization
	void Start ()
    {
        rend = gameObject.GetComponent<Renderer>();
        startingMaterial = rend.material;

        ObjectHide();
    }

    private void Update()
    {
        if (amActive && Input.GetAxis("Fire1") >= 1)
        {
            ObjectAction();
        }

        if (Input.GetAxis("Fire2") >= 1)
        {
            ObjectHide();
        }
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        if (amActive)
        {
            amActive = false;
        }
        else
        {
            rend.material = startingMaterial;
        }
    }

    public void ObjectHit()
    {
        amActive = true;
        rend.material = selectMaterial;
    }

    public virtual void ObjectAction()
    {
        if (activatingObject)
        {
            activatingObject.SetActive(true);
        }
    }

    public virtual void ObjectHide()
    {
        if (activatingObject)
        {
            activatingObject.SetActive(false);
        }
    }
}
