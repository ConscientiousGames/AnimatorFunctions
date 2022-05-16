using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AnimatorFunctions : MonoBehaviour
{
    //These scripts were made by looking up at Brackeys old and new videos and contains slight tweaks in them

    public Sound[] sounds;
    public Particle[] particles;

    public static AnimatorFunctions Instance;

    public void Awake()
    {
        if (Instance == null) Instance = this;
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
            
            s.source.loop = s.loop;
        }
    }

    //Call this function from animator by keeepin it on player, or you can call it via script as audiomager is static (Just like Game manger or player)
    public void PlaySound(string name)
    {
        foreach(Sound s1 in sounds)
        {

            s1.source.volume = s1.SetRandomVolume();
            s1.source.clip = s1.clips[UnityEngine.Random.Range(0, s1.clips.Length)];
            s1.source.pitch = s1.SetRandomPitch();
            //If u wanna tweak loop during play
            s1.source.loop = s1.loop;
        }
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogError("Sound: "+ name + " not found!");
        }
        s.source.Play();
    }

    public void EmitParticles(string name)
    {
        Particle p = Array.Find(particles, particle => particle.name == name);
        if (p == null) Debug.LogError("Particle: " + name + " not found!");
        p.particleSystem.Emit(p.emitAmount);
    }

    void Start()
    {
        
        //DontDestroyOnLoad(gameObject);
    }

    
    void Update()
    {
        
    }
}
