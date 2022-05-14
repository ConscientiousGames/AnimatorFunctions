using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //These scripts were made by looking up at Brackeys old and new videos and has my slight tweaks

    public Sound[] sounds;

    public static AudioManager instance;

    public void Awake()
    {
        if (instance == null) instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        foreach(Sound s in sounds)
        {
            //If You wanna have gameobject for each sound under your audiomanager object (whichever object this script is on)
            /*
            GameObject _go = new GameObject("Sound_" + s.name);
            _go.transform.SetParent(this.transform);
            s.source = _go.AddComponent<AudioSource>();
            */

            //The audiomanager object handling all audio sources
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.volume = s.SetRandomVolume();
            s.source.clip = s.clip;
            s.source.pitch = s.SetRandomPitch();
            s.source.loop = s.loop;
        }
    }

    //Call this function from animator by keeepin it on player, or you can call it via script as audiomager is static (Just like Game manger or player)
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null) Debug.LogError("Sound: " + s.name + "not found!");
        s.source.Play();
    }

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    
    void Update()
    {
        
    }
}
