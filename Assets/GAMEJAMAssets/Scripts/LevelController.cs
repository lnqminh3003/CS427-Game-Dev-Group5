using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class LevelController : MonoBehaviour
{
    private static LevelController instance;

    public static LevelController Instance{
        get{
            if (instance == null) 
            {
                instance = FindObjectOfType<LevelController>(true);
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

    [Header("Popup")]
    public GameObject GameOverPopup;
    public GameObject LevelCompletePopup;
    public GameObject PausePopup;
    public bool isTutorialDone = false;
    public bool isMoveTutorialDone =false;
    public bool isJumpTutorialDone =false;
    public bool isDoubleJumpTutorialDone =false;
    public bool isDashTutorialDone =false;
      
    PlayerHealth playerHealth;

    private void Start() {
        PauseButton.onClick.AddListener(OnClickPauseButton);

        playerHealth= FindObjectOfType<PlayerHealth>();
    }

    private void OnClickPauseButton(){
        PausePopup.SetActive(true);
    }

    private void OnClickGameOverButton(){
        GameOverPopup.SetActive(true);
    }

    private void OnClickLevelCompleteButton(){
        LevelCompletePopup.SetActive(true);
    }

    public void OnClickRestartButton(){
        Scene scene = SceneManager.GetActiveScene();
        if(scene.name == Scenes.Level1Test.ToString())
        {
            SceneManager.LoadScene(Scenes.Level1Test.ToString());
        }
        else if(scene.name == Scenes.Level2Scene.ToString()){
            SceneManager.LoadScene(Scenes.Level2Scene.ToString());
        }
        else if(scene.name == Scenes.Level3Scene.ToString()){
            SceneManager.LoadScene(Scenes.Level3Scene.ToString());
        }
    }

    public void OnClickMenuButton(){
        SceneManager.LoadScene(Scenes.MenuScene.ToString());
    }

    public void OnClickNextButton(){
        Scene scene = SceneManager.GetActiveScene();
        if(scene.name == Scenes.Level1Test.ToString())
        {
            SceneManager.LoadScene(Scenes.Level2Scene.ToString());
        }
        else if(scene.name == Scenes.Level2Scene.ToString()){
            SceneManager.LoadScene(Scenes.Level3Scene.ToString());
        }
        else if(scene.name == Scenes.Level3Scene.ToString()){
            Debug.Log("HELLO");
        }
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

    public void OpenPopupInventory(int typeBox){
        ItemController.Instance.FillItemToInventory(typeBox);
    }
}
