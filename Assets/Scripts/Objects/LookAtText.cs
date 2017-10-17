using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtText : MonoBehaviour
{


	// Update is called once per frame
	void FixedUpdate ()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - Camera.main.transform.position);
    }
}
