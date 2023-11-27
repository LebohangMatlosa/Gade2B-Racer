using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManager : MonoBehaviour
{
    public List<AudioClip> audioClips = new List<AudioClip>();
    private static SfxManager managing;
    private Dictionary<string, AudioClip> audioClipss = new Dictionary<string, AudioClip>();
    public void Start()
    {
        audioClips.Add(Resources.Load<AudioClip>("AduioClip1"));
        audioClips.Add(Resources.Load<AudioClip>("AduioClip2"));
        AddAudioClips("PoliceCar", Resources.Load<AudioClip>("PoliceCar"));
        AddAudioClips("KillaMachine", Resources.Load<AudioClip>("KillaMachine"));
        AddAudioClips("Tonka", Resources.Load<AudioClip>("Tonka"));
        AddAudioClips("Maserati", Resources.Load<AudioClip>("Maserati"));
        PlayAudioClip(0);
    }

    void AddAudioClips(string key, AudioClip clip)
    {
        if (!audioClipss.ContainsKey(key))
        {
            audioClipss.ContainsKey(key);
        }
        else
        {
            Debug.LogWarning("Audio clip with key" + key + "ALready exists");
        }
    }

    
    public static SfxManager Managing
    {
        get
        {
            if (managing == null)
            {
                managing = FindObjectOfType<SfxManager>();

            }
            if (managing == null)
            {
                GameObject carAudioSource = new GameObject(typeof(SfxManager).Name);
                managing = carAudioSource.AddComponent<SfxManager>();
            }
            return managing;
        }
        
    }

    private void Awake()
    {
       /* if (managing == null)
        {
            managing = this as SfxManager;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }*/
    }

    void PlayAudioClip(int index)
    {
        if (index>=0 && index < audioClips.Count)
        {
            AudioSource audioSource = GetComponent<AudioSource>();

            audioSource.clip = audioClips[index];
            audioSource.PlayOneShot(audioClips[index]);
        }
        else
        {
            Debug.Log("Couldnt foind the audio");
        }
    }
}
