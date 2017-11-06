using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBuilding : MonoBehaviour
{
    // Cost
    public int costMoney = 0;
    public int costPower = 0;
    public int costWater = 0;

    // Population
    public int affectStudents;
    public int affectCouples;
    public int affectFamilies;
    public int affectAncients;
    public int affectHippies;

    // Use this for initialization
    void OnEnable ()
    {
		
	}
	
	// Update is called once per frame
	void OnDisable ()
    {
		
	}
}
