using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopNext : BaseObject
{
    [Tooltip("Insert the gameObject using LaptopText script here.")]
    public LaptopText laptopText;

    public override void ObjectAction()
    {
        base.ObjectAction();

        if (laptopText)
        {
            laptopText.NextMessage();
        }
    }
}
