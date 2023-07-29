using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuSceneController : MonoBehaviour
{
    [Header("Button")]
    public Button PlayButton;
    public Button CreditButton;
    public Button ExitButton;
    public Button ShopButton;
    public Button LevelSelectButton;

    [Header("Pop up")]
    public GameObject CreditPopUp;

    void Start() {
        PlayButton.onClick.AddListener(OnClickPlayButton);
        CreditButton.onClick.AddListener(OnClickCreditButton);    
        ExitButton.onClick.AddListener(OnClickExitButton);
        ShopButton.onClick.AddListener(OnClickShopButton);
        LevelSelectButton.onClick.AddListener(OnClickLevelSelectButton);
    }

    private void OnClickPlayButton()
    {
        SceneManager.LoadScene(Scenes.Level1.ToString());
    }

    private void OnClickCreditButton()
    {
        CreditPopUp.SetActive(true);
    }

    private void OnClickExitButton()
    {
        #if UNITY_STANDALONE
                Application.Quit();
        #endif
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    private void OnClickShopButton()
    {
        SceneManager.LoadScene(Scenes.ShopScene.ToString());
    }

    private void OnClickLevelSelectButton()
    {
        SceneManager.LoadScene(Scenes.SelectScene.ToString());
    }
}
