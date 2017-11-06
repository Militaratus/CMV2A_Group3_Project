using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopItem : BaseItem
{
    public GameObject slider;
    public GameObject menu;
    public GameObject screen;

    public FolderItem folderItem;
    public bool activated;

	// Use this for initialization
	public override void ActivateButton()
    {
        if (folderItem.activated)
            folderItem.ToggleFolderMenu();

        ToggleEmailMenu();
    }

    public void ToggleEmailMenu()
    {
        if (!activated)
        {
            slider.SetActive(true);
            menu.SetActive(true);
            screen.SetActive(true);
            activated = true;
        }
        else
        {
            slider.SetActive(false);
            menu.SetActive(false);
            screen.SetActive(false);
            activated = false;
        }
    }
}
