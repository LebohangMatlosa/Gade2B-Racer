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
    private Queue<nonPlayer> npcCharacters;
    public TextAsset jsonFile;
    // Start is called before the first frame update
    void Start()
    {
        // Initializes the queue
        dialogueSentences = new Queue<string>();
        npcCharacters = new Queue<nonPlayer>();
        NonPlayerCharacters characInJSON = JsonUtility.FromJson<NonPlayerCharacters>(jsonFile.text);

        foreach (nonPlayer character in characInJSON.npcCharacters)
        {
            Debug.Log("Found NPC: " + character.npcName + "'" + character.npcDialogue + "'");
            npcCharacters.Enqueue(character);
        }

        // Start the dialogue with the first character
        if (npcCharacters.Count > 0)
        {
            startDialogue(npcCharacters.Peek()); // Peek at the first character without dequeuing
        }
    }

    // this takes in a dialogue parameter and starts the dialogue 
    public void startDialogue(nonPlayer npcDialogue)
    {
        Debug.Log("starting convo with " + npcDialogue.npcName);
        displayName.text = npcDialogue.npcName; // displays the name
        dialogueSentences.Clear(); // clears out the queue for new data to come in

        // loops through the array and enqueues each sentence in the array
        foreach (var dialogueSentence in npcDialogue.npcDialogue)
        {
            dialogueSentences.Enqueue(npcDialogue.npcDialogue);
        }

        // Display the first sentence
        displayNextSentence();
    }

    // displays the next queued sentence
    public void displayNextSentence()
    {
        if (dialogueSentences.Count == 0) // checks that if there are any queued items left
        {
            // End the dialogue for the current character
            endDialogue();

            // Dequeue the current character and start the next character's dialogue
            npcCharacters.Dequeue();

            if (npcCharacters.Count > 0)
            {
                startDialogue(npcCharacters.Peek());
            }
        }
        else
        {
            string sentence = dialogueSentences.Dequeue(); // removes the displayed sentence from the queue
            Debug.Log(sentence);
            StopAllCoroutines(); // this ensures that the current sentence finishes before the next

        }
    }

    public void endDialogue()
    {
        Debug.Log("end of convo");
    }
}

