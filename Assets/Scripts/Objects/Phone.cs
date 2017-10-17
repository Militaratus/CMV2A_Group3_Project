using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : BaseObject
{
    public override void ObjectAction()
    {
        base.ObjectAction();
        transform.GetChild(0).gameObject.SetActive(false);
    }

    public override void ObjectHide()
    {
        base.ObjectHide();
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
