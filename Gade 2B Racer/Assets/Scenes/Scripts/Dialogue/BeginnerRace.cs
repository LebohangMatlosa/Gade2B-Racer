using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeginnerRace : MonoBehaviour
{
    [SerializeField] private Queue<string> dialogue;
    [SerializeField] public string Announcer;
    [SerializeField] private TextMeshProUGUI display;
    public GameObject Text;
    void Start()
    {
        DialogueForCheeckpoint();
        Text.GetComponent<TextMeshProUGUI>().text = "Raeez";
    }
     
    void DialogueForCheeckpoint()
    {
        
        dialogue = new Queue<string>();
        dialogue.Enqueue("Hello");
        dialogue.Enqueue("Welcome to the time trial race");
        dialogue.Enqueue("You will have to beat the race and cross the finish line before the timer runs out");
        dialogue.Enqueue("To start press the start timer button when you are ready to go ");
        dialogue.Enqueue("Good Luck!!");
    }

    public void nextSentence()
    {
        display.text = dialogue.Peek();
        dialogue.Dequeue();
    }
}
