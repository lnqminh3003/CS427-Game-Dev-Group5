using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public void PlayMusic()
    {
        AudioManager.instance.PlaySoundtrack("SevenNationArmy");
    }
    
    public void StopMusic()
    {
        AudioManager.instance.StopSoundTrack();
    }

    public void PlayBtnSfx()
    {
        AudioManager.instance.PlaySfx("ButtonClick01");
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(AudioManager.instance.isPlayingSoundtrack());
    }
}
