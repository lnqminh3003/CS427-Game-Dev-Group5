using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class UILevel1Controller : MonoBehaviour
{
    private static UILevel1Controller instance;

    public static UILevel1Controller Instance{
        get{
            if (instance == null) 
            {
                instance = FindObjectOfType<UILevel1Controller>(true);
            }
             return instance;
        }
    }

    private void Awake() {
        if(instance != null)
        {
            Destroy(instance.gameObject);
        }
        instance = this;
    }

    [Header("Button")]
    public Button PauseButton;
    public Button Level2Button;
    public Button RetryButton;
    public Button MenuButton;

    [Header("Popup")]
    public GameObject GameOverPopup;
    public GameObject LevelCompletePopup;
    public GameObject FailPopup;
    public GameObject PausePopup;
      
    PlayerHealth playerHealth;

    private void Start() {
        PauseButton.onClick.AddListener(() =>
        {
            PausePopup.SetActive(true);
        });

        Level2Button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(Scenes.Level2.ToString());
        });

        RetryButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(Scenes.Level1.ToString());
        });

        MenuButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(Scenes.MenuScene.ToString());
        });

        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    private void OnClickGameOverButton(){
        GameOverPopup.SetActive(true);
    }

    private void OnClickLevelCompleteButton(){
        LevelCompletePopup.SetActive(true);
    }

    public void OnClickRestartButton(){
        SceneManager.LoadScene(Scenes.Level1.ToString());
    }

    public void OnClickMenuButton(){
        SceneManager.LoadScene(Scenes.MenuScene.ToString());
    }

    public void OnClickCancelPopupButton(){
        PausePopup.SetActive(false);
        LevelCompletePopup.SetActive(false);
        GameOverPopup.SetActive(false);
    }

    public void OnClickSoundButton(){

    }

    public void OnClickMusicButton(){
        
    }
}
