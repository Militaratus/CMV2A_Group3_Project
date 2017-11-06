using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderItem : BaseItem
{
    public GameObject slider;
    public GameObject menu;

    public LaptopItem laptopItem;
    public bool activated;

    // Use this for initialization
    public override void ActivateButton()
    {
        if (laptopItem.activated)
            laptopItem.ToggleEmailMenu();

        ToggleFolderMenu();
    }

    public void ToggleFolderMenu()
    {
        if (!activated)
        {
            slider.SetActive(true);
            menu.SetActive(true);
            activated = true;
        }
        else
        {
            slider.SetActive(false);
            menu.SetActive(false);
            activated = false;
        }
    }
}
