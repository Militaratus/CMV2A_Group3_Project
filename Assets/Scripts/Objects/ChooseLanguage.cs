using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseLanguage : BaseItem
{
    public TranslationManager managerTranslation;
    public string language;

    void Start()
    {
        if (managerTranslation == null)
        {
            managerTranslation = GameObject.Find("__Managers").GetComponent<TranslationManager>();
        }
    }

    public override void ActivateButton()
    {
        if (managerTranslation == null)
        {
            managerTranslation = GameObject.Find("__Managers").GetComponent<TranslationManager>();
        }

        managerTranslation.language = language;
    }
}
