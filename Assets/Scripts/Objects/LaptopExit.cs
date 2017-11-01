using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopExit : BaseItem
{
    public LaptopItem laptop;

    // Use this for initialization
    public override void ActivateButton()
    {
        m_GazeOver = false;
        laptop.ToggleEmailMenu();
    }
}
