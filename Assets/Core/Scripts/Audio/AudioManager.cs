using UnityEngine.Audio;
using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [Range(0f, 1f)]
    public float currentVolumeMusic;
    [Range(0f, 1f)]
    public float currentVolumeSound;
    [Header("------------------Sfx-------------------------")]
    public AudioClip[] sfx;
    public AudioSource audioSource;

    void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

    }

    public void SetVolume(float _soundtrackVolume, float _sfxVolume)
    {
        SetVolumeMusic(_soundtrackVolume);
        SetVolumeSound(_sfxVolume);
    }

    public void SetVolumeMusic(float _soundtrackVolume)
    {
        
    }

    public void SetVolumeSound(float _sfxVolume)
    {
       
    }

    public bool isPlayingSoundtrack()
    {
        return true;
    }

    public bool isPlayingSfx(string key)
    {
        return true;
    }

    public void PlayRandomSoundtrack()
    {

    }

    public void PlaySoundtrack(string key)
    {

    }

    public void PlaySfx(string key)
    {

    }

    public void Stop(string key, SoundType type)
    {

    }

    public void StopSoundTrack()
    {
       
    }



}
