using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIShopController : MonoBehaviour
{
    public Button returnButton;

    private void Start()
    {
        returnButton.onClick.AddListener(() =>
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(Scenes.MenuScene.ToString());
        });
    }
}
