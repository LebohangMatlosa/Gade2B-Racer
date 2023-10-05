using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
public class BeginnerRace : MonoBehaviour
{
    [SerializeField] private SerilizableDialogue<string> dialogue;
    [SerializeField] public string Announcer;
    [SerializeField] private TextMeshProUGUI display;
    
    public GameObject Text;
    void Start()
    {
        DialogueForCheeckpoint();
        Text.GetComponent<TextMeshProUGUI>().text = "Raeez";
    }
     
    public void DialogueForCheeckpoint()
    {
        
        //dialogue = new Queue<string>();
        dialogue.queue.Enqueue("Hello");
        dialogue.queue.Enqueue("Welcome to the time trial race");
        dialogue.queue.Enqueue("You will have to beat the race and cross the finish line before the timer runs out");
        dialogue.queue.Enqueue("To start press the start timer button when you are ready to go ");
        dialogue.queue.Enqueue("Good Luck!!");
        dialogue.list = new List<string>(dialogue.queue);
        var Json = JsonUtility.ToJson(dialogue);
        
        Debug.Log(Json + "converted");
        System.IO.File.WriteAllText(Application.persistentDataPath + "/DialogueStorage.json",Json);
        Debug.Log(Application.persistentDataPath + "/DialogueStorage.json");
    }

    public void nextSentence()
    {
        display.text = dialogue.queue.Peek();
        dialogue.queue.Dequeue();
    }
    [System.Serializable]
    public class SerilizableDialogue<T>
    {
        public Queue<T> queue = new Queue<T>();

        public List<T> list;


        
    }

    
}
