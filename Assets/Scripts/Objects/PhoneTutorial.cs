using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneTutorial : MonoBehaviour
{
    public AudioSource audioPlayer;
    public AudioClip english;
    public AudioClip dutch;

    // Manager
    private TranslationManager managerTranslation;

	// Use this for initialization
	void OnEnable ()
    {
		if (managerTranslation == null)
        {
            managerTranslation = GameObject.Find("__Managers").GetComponent<TranslationManager>();
        }

        if (managerTranslation.language == "Dutch")
        {
            audioPlayer.clip = dutch;
        }
        else
        {
            audioPlayer.clip = english;
        }
        audioPlayer.Play();
    }
	
	// Update is called once per frame
	void OnDisable ()
    {
        audioPlayer.Stop();
    }
}
