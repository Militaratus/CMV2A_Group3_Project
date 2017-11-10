using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaptopText : MonoBehaviour
{
    // Interal
    GameManager managerGame;
    TranslationManager managerTranslate;
    int emailCount = 0;
    public Text myText;

    public string[] emailMessages;

	// Use this for initialization
	void Start ()
    {
        managerGame = GameObject.Find("__Managers").GetComponent<GameManager>();
        managerTranslate = GameObject.Find("__Managers").GetComponent<TranslationManager>();

        managerTranslate.Translation(myText, "email_welcome");

        // Quest Messages
        if (managerGame.questFountain == true)
        {
            emailMessages[0] = "scenario_1_complete";
        }

        if (managerGame.questHousing == true)
        {
            emailMessages[1] = "scenario_4_complete";
        }
    }

    public void NextMessage()
    {
        managerTranslate.Translation(myText, emailMessages[emailCount]);
        emailCount++;

        if (emailCount >= emailMessages.Length)
            emailCount = 0;
    }
}
