using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaptopText : MonoBehaviour
{
    // Interal
    TranslationManager managerTranslate;
    int emailCount = 0;
    public Text myText;

    [TextArea(1, 10)]
    public string[] emailMessages;

	// Use this for initialization
	void Start ()
    {
        managerTranslate = GameObject.Find("__Managers").GetComponent<TranslationManager>();

        managerTranslate.Translation(myText, "email_welcome");
    }

    public void NextMessage()
    {
        managerTranslate.Translation(myText, emailMessages[emailCount]);
        emailCount++;

        if (emailCount >= emailMessages.Length)
            emailCount = 0;
    }
}
