using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseFolder : MonoBehaviour
{
    // Text References
    public Text textName;
    public Text textMoney;
    public Text textPower;
    public Text textWater;

    // Name
    public string nameBuilding;

    // Cost
    public int costMoney;
    public int costPower;
    public int costWater;

    // Internal
    TranslationManager managerTranslate;

    private void Start()
    {
        managerTranslate = GameObject.Find("__Managers").GetComponent<TranslationManager>();
    }

    // Use this for initialization
    void OnEnable ()
    {
        if (managerTranslate == null)
            managerTranslate = GameObject.Find("__Managers").GetComponent<TranslationManager>();

        managerTranslate.Translation(textName, nameBuilding);
        textMoney.text = costMoney.ToString();
        textPower.text = costPower.ToString();
        textWater.text = costWater.ToString();

    }
}
