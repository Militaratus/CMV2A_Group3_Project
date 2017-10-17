using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelView : BaseObject
{
    public override void ObjectAction()
    {
        Vector3 myCamPos = Camera.main.transform.position;

        Camera.main.transform.position = new Vector3(200, myCamPos.y, myCamPos.z);
    }

    public override void ObjectHide()
    {
        Vector3 myCamPos = Camera.main.transform.position;

        Camera.main.transform.position = new Vector3(0, myCamPos.y, myCamPos.z);
    }
}
