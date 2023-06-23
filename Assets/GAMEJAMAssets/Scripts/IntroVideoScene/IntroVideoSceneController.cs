using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroVideoSceneController : MonoBehaviour
{
    [Header("Button")]
    public Button SkipButton;
    public Button BackButton;

    private void Start() {
        SkipButton.onClick.AddListener(OnClickSkipButton);
        BackButton.onClick.AddListener(OnClickBackButton);
    }

    private void OnClickSkipButton(){
        SceneManager.LoadScene(Scenes.TutorialScene.ToString());
    }

    private void OnClickBackButton(){
        SceneManager.LoadScene(Scenes.MenuScene.ToString());
    }
}
