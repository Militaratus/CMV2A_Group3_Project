using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopText : MonoBehaviour
{
    // Interal
    int emailCount = 0;
    TextMesh myText;

    [TextArea(1, 10)]
    public string[] emailMessages;

	// Use this for initialization
	void Start ()
    {
        myText = GetComponent<TextMesh>();

        if (emailMessages.Length == 1)
        {
            myText.text = "Beste burgermeester, \n" + 
                "\n" + 
                "u heeft [ 1 ] bericht.";
        }
        else
        {
            myText.text = "Beste burgermeester, \n" +
                "\n" +
                "u heeft [ " + emailMessages.Length + " ] berichten.";
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
