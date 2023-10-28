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
    // Start is called before the first frame update
    void Start()
    {
        dialogueSentences = new Queue<string>();
    }

    public void startDialogue(Dialogue announcerDialogue)
    {
        Debug.Log("Starting conversation with " + announcerDialogue.announcerName);
        displayName.text = announcerDialogue.announcerName;
        dialogueSentences.Clear();

        foreach (var dialogueSentence in announcerDialogue.announcerName)
        {
            //dialogueSentences.Enqueue(dialogueSentence);
        }
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
        StartCoroutine(typeSentence(sentence));

        IEnumerator typeSentence(string sentence)
        {
            displayDialogue.text = "";
            foreach (char letter in sentence.ToCharArray())
            {
                displayDialogue.text += letter;
                yield return new WaitForSeconds(0.15f);
            }
        }
    }

    public void endDialogue()
    {
        Debug.Log("End Of Convo");
    }
   
}
