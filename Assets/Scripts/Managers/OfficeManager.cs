using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfficeManager : MonoBehaviour
{
    private GameManager managerGame;

    // Resources
    public Slider sliderMoney;
    public Text textMoney;
    public Slider sliderPower;
    public Text textPower;
    public Slider sliderWater;
    public Text textWater;

    // People
    public Slider sliderStudents;
    public Slider sliderCouples;
    public Slider sliderFamilies;
    public Slider sliderAncients;
    public Slider sliderHippies;

    // Use this for initialization
    void Start ()
    {
        managerGame = GameObject.Find("__Managers").GetComponent<GameManager>();
        AdjustResources();
        AdjustPeople();
    }

    void AdjustResources()
    {
        sliderMoney.value = managerGame.money / 7500000;
        sliderPower.value = managerGame.power / 1000;
        sliderWater.value = managerGame.water / 1000;

        textMoney.text = "€ " + managerGame.money;
        textPower.text = managerGame.power + " / 1000";
        textWater.text = managerGame.water + " / 1000";
    }

    void AdjustPeople()
    {
        Debug.Log(managerGame.students);
        sliderStudents.value = managerGame.students / 100;
        sliderCouples.value = managerGame.couples / 100;
        sliderFamilies.value = managerGame.families / 100;
        sliderAncients.value = managerGame.ancients / 100;
        sliderHippies.value = managerGame.hippies / 100;
    }
}
