using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONScripts : MonoBehaviour
{
    public TextAsset jsonFile;
    // Start is called before the first frame update
    void Start()
    {
        NotAnnoucner announcerInJSON = JsonUtility.FromJson<NotAnnoucner>(jsonFile.text);
        foreach (AnnouncerScript announcer in announcerInJSON.announcerScript)
        {
            Debug.Log("Found announcer: " + announcer.announcerName + "'" + announcer.announcerDialogue + "'");
        }
    }

}
