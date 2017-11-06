using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranslationManager : MonoBehaviour
{
    private DataService db;

    private void Start()
    {
        db = new DataService("existing.db");
    }

    public void Translation(Text activeText, string key)
    {

        if (db == null)
        {
            db = new DataService("existing.db");
        }

        activeText.text = db.GetDutch(key);
    }
}
