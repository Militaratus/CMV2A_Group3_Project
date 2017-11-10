using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour
{
    // Game Manager
    private GameManager managerGame;

    // Resource Sliders
    public Slider moneySlider;
    public Text moneyText;
    public Slider powerSlider;
    public Text powerText;
    public Slider waterSlider;
    public Text waterText;

    // Happiness Sliders
    public Slider studentSlider;
    public Slider coupleSlider;
    public Slider familySlider;
    public Slider ancientSlider;
    public Slider hippySlider;

    // Use this for initialization
    void Start ()
    {
        managerGame = GameObject.Find("__Managers").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (managerGame == null)
        {
            managerGame = GameObject.Find("__Managers").GetComponent<GameManager>();
        }

        // Resource update
        moneySlider.value = managerGame.money / 7500000;
        moneyText.text = "€ " + managerGame.money;
        powerSlider.value = managerGame.power / 1000;
        powerText.text = managerGame.power + " / 1000";
        waterSlider.value = managerGame.water / 1000;
        waterText.text = managerGame.water + " / 1000";

        // Happiness update
        studentSlider.value = managerGame.students / 100;
        coupleSlider.value = managerGame.couples / 100;
        familySlider.value = managerGame.families / 100;
        ancientSlider.value = managerGame.ancients / 100;
        hippySlider.value = managerGame.hippies / 100;
    }
}
