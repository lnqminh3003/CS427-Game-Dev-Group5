using UnityEngine.Audio;
using UnityEngine;


public enum SoundType
{
    Soundtrack, Sfx
}

[System.Serializable]
public class Sound
{
    public string key;
    public AudioClip clip;

    [Range(-3f, 3f)]
    public float pitch;
    [Range(0f, 1f)]
    public float volume;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
