using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashManager : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        // Load the level.
        SceneManager.LoadScene("LanguageMenu", LoadSceneMode.Single);
    }
}
