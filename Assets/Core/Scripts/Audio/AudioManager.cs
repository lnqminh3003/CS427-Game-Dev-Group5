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

    public void PlaySfx(string key)
    {
        if (key == "jump")
        {
            audioSource.clip = sfx[1];
        }
        else if (key == "dash")
        {
            audioSource.clip = sfx[0];
        }
        else if (key == "die")
        {
            audioSource.clip = sfx[2];
        }
        else if (key == "collect")
        {
            audioSource.clip = sfx[3];
        }
        else if (key == "kill")
        {
            audioSource.clip = sfx[4];
        }
        audioSource.Play();

    }
}
