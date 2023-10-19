using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;

public class AIRaceBegginer : MonoBehaviour
{

    [SerializeField] private SerilizableDialogue<string> dialogue;
    [SerializeField] public string Announcer;
    [SerializeField] private TextMeshProUGUI display;

    public GameObject Text;
    void Start()
    {
        DialogueForCheeckpoint();
        Text.GetComponent<TextMeshProUGUI>().text = "Guy Coolman";
    }

    public void DialogueForCheeckpoint()
    {

        //dialogue = new Queue<string>();
        dialogue.queue.Enqueue("Hello everyone!");
        dialogue.queue.Enqueue("This is Guy Coolman");
        dialogue.queue.Enqueue("Back again with another race for you all!");
        dialogue.queue.Enqueue("Today our new rookie will be going up against our newer racers!");
        dialogue.queue.Enqueue("Our rookie will have to win a Lap against all the other racers to progress onto the next race!");
        dialogue.queue.Enqueue("As always we wish all our racers good luck!");
        dialogue.queue.Enqueue("Press the start race button when you are ready rookie!");
        dialogue.list = new List<string>(dialogue.queue);
        var Json = JsonUtility.ToJson(dialogue);

        Debug.Log(Json + "converted");
        System.IO.File.WriteAllText(Application.persistentDataPath + "/DialogueStorage.json", Json);
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
