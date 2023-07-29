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
    [Header("------------------Sound tracks-------------------------")]
    public Sound[] soundtracks;
    [Header("------------------Sfx-------------------------")]
    public Sound[] sfx;
    //---------------------------------------------------------
    private Dictionary<string, Sound> dictSoundtracks;
    private Dictionary<string, Sound> dictSfx;
    private string currentSoundTrackKey;


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

        foreach (Sound s in soundtracks)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.pitch = s.pitch;
            s.volume = s.volume * currentVolumeMusic;
            s.source.volume = s.volume;
            s.source.loop = true;
        }
        foreach (Sound s in sfx)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.pitch = s.pitch;
            s.volume = s.volume * currentVolumeSound;
            s.source.volume = s.volume;
            s.source.loop = false;
            s.source.Stop();
            s.source.playOnAwake = false;
        }


        dictSoundtracks = soundtracks.ToDictionary(sound => sound.key);
        dictSfx = sfx.ToDictionary(sound => sound.key);
        foreach (var child in dictSfx) Debug.Log(child.Key);
    }

    public void SetVolume(float _soundtrackVolume, float _sfxVolume)
    {
        SetVolumeMusic(_soundtrackVolume);
        SetVolumeSound(_sfxVolume);
    }

    public void SetVolumeMusic(float _soundtrackVolume)
    {
        foreach (Sound s in soundtracks)
        {
            s.volume = _soundtrackVolume;
            s.source.volume = _soundtrackVolume;
        }
        currentVolumeMusic = _soundtrackVolume;
    }

    public void SetVolumeSound(float _sfxVolume)
    {
        foreach (Sound s in sfx)
        {
            s.volume = _sfxVolume;
            s.source.volume = _sfxVolume;
        }
        currentVolumeSound = _sfxVolume;
    }

    public bool isPlayingSoundtrack()
    {
        var playingSoundtrack = soundtracks.ToList().Find(s => s.source.isPlaying);
        return playingSoundtrack != null;
    }

    public bool isPlayingSfx(string key)
    {
        return dictSfx[key].source.isPlaying;
    }

    public void PlayRandomSoundtrack()
    {
        if (!isPlayingSoundtrack())
        {
            var rnd = new System.Random();
            int index = rnd.Next(soundtracks.Count());
            soundtracks[index].source.Play();
            currentSoundTrackKey = soundtracks[index].key;
        }
    }

    public void PlaySoundtrack(string key)
    {
        if (!isPlayingSoundtrack())
        {
            dictSoundtracks[key].source.Play();
            currentSoundTrackKey = key;
        }
    }

    public void PlaySfx(string key)
    {
        if (dictSfx[key] == null) return;
        dictSfx[key].source.Play();
    }

    public void Stop(string key, SoundType type)
    {
        switch (type)
        {
            case SoundType.Soundtrack:
                dictSoundtracks[key].source.Stop();
                break;
            case SoundType.Sfx:
                dictSfx[key].source.Stop();
                break;
            default:
                break;
        }
    }

    public void StopSoundTrack()
    {
        dictSoundtracks[currentSoundTrackKey].source.Stop();
    }

    void FixedUpdate()
    {
        if (!dictSoundtracks[currentSoundTrackKey].source.isPlaying)
            PlayRandomSoundtrack();
    }

}
