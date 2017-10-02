using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseObject : MonoBehaviour
{
    Material startingMaterial;
    public Material selectMaterial;

    Renderer rend;

    bool amActive = false;

	// Use this for initialization
	void Start ()
    {
        rend = gameObject.GetComponent<Renderer>();
        startingMaterial = rend.material;
        
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
        print("Main Screen Turn On");
    }

    public virtual void ObjectHide()
    {

    }
}
