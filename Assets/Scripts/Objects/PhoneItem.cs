using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneItem : BaseItem
{
    public GameObject screen;
    private bool activated;

    // Use this for initialization
    public override void ActivateButton()
    {
        TogglePhone();
    }

    public void TogglePhone()
    {
        if (!activated)
        {
            screen.SetActive(true);
            activated = true;
        }
        else
        {
            screen.SetActive(false);
            activated = false;
        }
    }
}
