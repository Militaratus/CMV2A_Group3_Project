using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopItem : BaseItem
{
    public Transform slider;
    public Transform menu;

    private bool activated;

	// Use this for initialization
	public override void ActivateButton()
    {
        ToggleEmailMenu();
    }

    public void ToggleEmailMenu()
    {
        if (!activated)
        {
            slider.gameObject.SetActive(true);
            menu.gameObject.SetActive(true);
            activated = true;
        }
        else
        {
            slider.gameObject.SetActive(false);
            menu.gameObject.SetActive(false);
            activated = false;
        }
    }
}
