using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaptopNext : BaseItem
{
    [Tooltip("Insert the gameObject using LaptopText script here.")]
    public LaptopText laptopText;

    // Interal
    TranslationManager managerTranslate;
    public Text myText;

    private void Start()
    {
        managerTranslate = GameObject.Find("__Managers").GetComponent<TranslationManager>();
        managerTranslate.Translation(myText, "email_next");
    }

    // Use this for initialization
    public override void ActivateButton()
    {
        laptopText.NextMessage();
    }
}
