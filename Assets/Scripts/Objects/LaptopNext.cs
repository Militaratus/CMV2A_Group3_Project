using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopNext : BaseItem
{
    [Tooltip("Insert the gameObject using LaptopText script here.")]
    public LaptopText laptopText;

    // Use this for initialization
    public override void ActivateButton()
    {
        laptopText.NextMessage();
    }
}
