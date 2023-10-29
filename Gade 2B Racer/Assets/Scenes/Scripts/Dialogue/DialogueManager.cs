using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI displayName;
    public TextMeshProUGUI displayDialogue;
    public Queue<string> dialogueSentences;
    public TextAsset jsonFile;
    // Start is called before the first frame update
    void Start()
    {
        dialogueSentences = new Queue<string>();
        NonPlayerCharacters announcerInJSON = JsonUtility.FromJson<NonPlayerCharacters>(jsonFile.text);
        foreach (nonPlayer announcer in announcerInJSON.npcCharacters)
        {
            Debug.Log("Found announcer: " + announcer.npcName + "'" + announcer.npcDialogue + "'");
            displayName.text = announcer.npcName;
            //dialogueSentences.Clear();
            dialogueSentences.Enqueue(announcer.npcDialogue);
            

        }
        displayNextSentence();
    }

    public void startDialogue(nonPlayer announcerDialogue)
    {
        Debug.Log("Starting conversation with " +announcerDialogue.npcName);
        /*displayName.text = announcerDialogue.announcerName;
        dialogueSentences.Clear();*/

        /*foreach (var dialogueSentence in announcerDialogue.announcerName)
        {
            //dialogueSentences.Enqueue(dialogueSentence);
        }*/
        displayNextSentence();
    }

    public void displayNextSentence()
    {
        if (dialogueSentences.Count==0)
        {
            endDialogue();
            return;
        }
        string sentence = dialogueSentences.Dequeue();
        Debug.Log(sentence);
        //StopAllCoroutine();
        //StartCoroutine(typeSentence(sentence));

        /*IEnumerator typeSentence(string sentence)
        {
            displayDialogue.text = "";
            foreach (char letter in sentence.ToCharArray())
            {
                displayDialogue.text += letter;
                yield return new WaitForSeconds(0.15f);
            }
        }*/
    }

    public void endDialogue()
    {
        Debug.Log("End Of Convo");
    }
   
}
