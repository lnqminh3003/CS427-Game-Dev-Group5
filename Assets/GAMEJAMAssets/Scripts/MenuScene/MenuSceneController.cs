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
    public Button LetGoButton;

    [Header("Pop up")]
    public GameObject CreditPopUp;

    void Start() {
        PlayButton.onClick.AddListener(OnClickPlayButton);
        CreditButton.onClick.AddListener(OnClickCreditButton);    
        ExitButton.onClick.AddListener(OnClickExitButton);
        LetGoButton.onClick.AddListener(OnClickLetGoButton);
    }

    private void OnClickPlayButton()
    {
        SceneManager.LoadScene(Scenes.Level1Test.ToString());
    }

    private void OnClickCreditButton()
    {
        CreditPopUp.SetActive(true);
    }

    private void OnClickExitButton()
    {
        
    }

    private void OnClickLetGoButton()
    {
        CreditPopUp.SetActive(false);
    }
}
