using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopObject : BaseObject
{
    public GameObject mainScreen;

    public override void ObjectAction()
    {
        base.ObjectAction();

        if (mainScreen)
        {
            mainScreen.SetActive(true);
        }
    }

    public override void ObjectHide()
    {
        base.ObjectHide();

        mainScreen.SetActive(false);
    }
}
