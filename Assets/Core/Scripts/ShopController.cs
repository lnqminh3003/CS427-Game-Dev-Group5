using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    public Button buyFastButton;
    public Button buyHeartButton;
    public GameObject buyFailPopup;
    public GameObject buySuccessPopup;

    private void Start()
    {
        buyFastButton.onClick.AddListener(() =>
        {
            GameManager.Instance.buyShop(1);
        });

        buyHeartButton.onClick.AddListener(() =>
        {
            GameManager.Instance.buyShop(2);
        });
    }
}
