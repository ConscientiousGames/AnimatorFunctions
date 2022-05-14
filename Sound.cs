using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    //These scripts were made by looking up at Brackeys old and new videos and contains slight tweaks in them

    //This boy stores all the values and have randomising functions in it

    public string name;
    public AudioClip[] clips;
    [Range(0, 1f)]
    public float volume;
    [Range(0.1f, 3f)]
    public float pitch;
    [Range(0, 0.5f)]
    public float randomVolume;
    [Range(0, 0.5f)]
    public float randomPitch;
    public bool loop;
    [HideInInspector]
    public AudioSource source;

    public float SetRandomVolume ()
    {
        float _volume = volume * (1 + Random.Range(-randomVolume / 2f, randomVolume / 2f));
        return _volume;
    }

    public float SetRandomPitch()
    {
        float _pitch = pitch * (1 + Random.Range(-randomPitch / 2f, randomPitch / 2f));
        return _pitch;
    }
}
