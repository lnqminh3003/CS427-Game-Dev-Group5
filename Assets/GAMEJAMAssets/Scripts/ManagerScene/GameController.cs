using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Singleton<GameController>
{
    public bool isPlayFirstTime = false;

    private void Start()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Scenes.MenuScene.ToString());
        AudioManager.instance.PlayRandomSoundtrack();
    }
}
