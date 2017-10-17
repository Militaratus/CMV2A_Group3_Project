using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_LookAt : MonoBehaviour {
    public Camera camera;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 100;
        Debug.DrawRay(camera.transform.position, forward, Color.green);

        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, forward, out hit, 100.0f))
        {
            //print("Found " + hit.transform.gameObject.name + " - distance: " + hit.distance);
            BaseObject validObject = hit.transform.gameObject.GetComponent<BaseObject>();
            if (validObject)
                validObject.ObjectHit();

            BaseCP validCP = hit.transform.gameObject.GetComponent<BaseCP>();
            if (validCP)
                validCP.ObjectHit();
        }
            
    }
}
