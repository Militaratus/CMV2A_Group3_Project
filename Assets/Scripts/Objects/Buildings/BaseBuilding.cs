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
    public int affectStudents = 0;
    public int affectCouples = 0;
    public int affectFamilies = 0;
    public int affectAncients = 0;
    public int affectHippies = 0;

    // Game Manager
    private GameManager managerGame;

    public void BringMeToLife ()
    {
        if (managerGame == null)
        {
            managerGame = GameObject.Find("__Managers").GetComponent<GameManager>();
        }

        // Resources
        managerGame.SpendMoney(costMoney);
        managerGame.SpendPower(costPower);
        managerGame.SpendWater(costWater);

        // Affection
        managerGame.AffectStudents(affectStudents);
        managerGame.AffectCouples(affectCouples);
        managerGame.AffectFamilies(affectFamilies);
        managerGame.AffectAncients(affectAncients);
        managerGame.AffectHippies(affectHippies);
    }
	
	public void KillMe ()
    {
        if (managerGame == null)
        {
            managerGame = GameObject.Find("__Managers").GetComponent<GameManager>();
        }

        // Resources
        managerGame.SpendMoney(-costMoney);
        managerGame.SpendPower(-costPower);
        managerGame.SpendWater(-costWater);

        // Affection
        managerGame.AffectStudents(-affectStudents);
        managerGame.AffectCouples(-affectCouples);
        managerGame.AffectFamilies(-affectFamilies);
        managerGame.AffectAncients(-affectAncients);
        managerGame.AffectHippies(-affectHippies);
    }
}
