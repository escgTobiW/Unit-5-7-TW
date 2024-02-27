using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerController : MonoBehaviour
{
    [SerializeField] private AudioMixer Amix;

    public void SetMasterVolume (float sliderValue)
    {
        Amix.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20); 

    }

    public void SetMusicVolume(float sliderValue)
    {
        Amix.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);

    }

    public void SetSFXVolume(float sliderValue)
    {
        Amix.SetFloat("SFXVolume", Mathf.Log10(sliderValue) * 20);

    }
}
