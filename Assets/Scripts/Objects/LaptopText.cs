using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopText : MonoBehaviour
{
    // Interal
    TranslationManager managerTranslate;
    int emailCount = 0;
    TextMesh myText;

    [TextArea(1, 10)]
    public string[] emailMessages;

	// Use this for initialization
	void Start ()
    {
        managerTranslate = GameObject.Find("__Managers").GetComponent<TranslationManager>();

        myText = GetComponent<TextMesh>();

        if (emailMessages.Length == 1)
        {
            managerTranslate.Translation(myText, "email_welcome_1");
        }
        else
        {
            managerTranslate.Translation(myText, "email_welcome_start");
            myText.text = myText.text + emailMessages.Length;
            managerTranslate.Translation(myText, "email_welcome_end", true);
        }
    }

    public void NextMessage()
    {
        myText.text = emailMessages[emailCount];
        emailCount++;

        if (emailCount >= emailMessages.Length)
            emailCount = 0;
    }
}
