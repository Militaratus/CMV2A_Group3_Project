using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaptopExit : BaseItem
{
    public LaptopItem laptop;

    // Interal
    TranslationManager managerTranslate;
    public Text myText;

    private void Start()
    {
        managerTranslate = GameObject.Find("__Managers").GetComponent<TranslationManager>();
        managerTranslate.Translation(myText, "email_exit");
    }

    // Use this for initialization
    public override void ActivateButton()
    {
        m_GazeOver = false;
        laptop.ToggleEmailMenu();
    }
}
