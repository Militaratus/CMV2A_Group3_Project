using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class TranslationManager : MonoBehaviour
{
    public void Translation(Text activeText, string key, bool noReplace = false)
    {
        StartCoroutine(GetText(activeText, key, noReplace));
    }

    IEnumerator GetText(Text activeText, string key, bool noReplace = false)
    {
        string translatedText = "";
        UnityWebRequest www = UnityWebRequest.Get("http://www.jarednealon.com/VR_Project/GetTranslation.php?myform_hash=hashcode&myform_translationKey=" + key);
        yield return www.SendWebRequest();

        if (www.isNetworkError)
        {
            translatedText = www.error;
        }
        else
        {
            translatedText = www.downloadHandler.text;
        }

        yield return null;
        if (noReplace)
        {
            activeText.text = activeText.text + translatedText;
        }
        else
        {
            activeText.text = translatedText;
        }
    }
}
