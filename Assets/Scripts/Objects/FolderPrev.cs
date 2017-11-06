using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FolderPrev : BaseItem
{
    [Tooltip("Insert the gameObject using LaptopText script here.")]
    public FolderSelect folderSelect;

    // Interal
    TranslationManager managerTranslate;
    public Text myText;

    private void Start()
    {
        managerTranslate = GameObject.Find("__Managers").GetComponent<TranslationManager>();
        managerTranslate.Translation(myText, "folder_prev");
    }

    // Use this for initialization
    public override void ActivateButton()
    {
        folderSelect.PrevBuilding();
    }
}
