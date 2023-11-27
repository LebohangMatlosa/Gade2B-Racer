using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToRaceScreen()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitApp()
    {
        Application.Quit();
    }

    public void LoadRaceDialogue()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadTimeTrialRace()
    {
        SceneManager.LoadScene(3);
    }
    
    public void loadAdvancedRace()
    {
        SceneManager.LoadScene(4);
    }

    public void loadLebosRace()
    {
        SceneManager.LoadScene(5);
    }

    public void loadRaeezsRace()
    {
        SceneManager.LoadScene(6);
    }
}
