using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIShopController : MonoBehaviour
{
    public Button returnButton;
    public TextMeshProUGUI coinText;

    private void Start()
    {
        returnButton.onClick.AddListener(() =>
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(Scenes.MenuScene.ToString());
        });

        coinText.text = GameManager.Instance.coin.ToString();
    }
}
