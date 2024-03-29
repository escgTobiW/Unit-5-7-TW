using UnityEngine.Audio;
using System;
using UnityEngine;


[System.Serializable]
public class Sound 
{
    public string name;

    public AudioClip clip;

    [Range(0f,10f)]
    public float volume;
    [Range(0.1f, 3f)]
    public float pitch;


    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
