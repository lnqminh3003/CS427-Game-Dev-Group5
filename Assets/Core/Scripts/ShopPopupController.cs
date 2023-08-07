using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPopupController : MonoBehaviour
{
    public Button buyFastButton;
    public Button buyHeartButton;
    public GameObject buyFailPopup;
    public GameObject buySuccessPopup;

    private void Start()
    {
        buyFastButton.onClick.AddListener(() =>
        {
            GameManager.Instance.buyShopPopup(1);
        });

        buyHeartButton.onClick.AddListener(() =>
        {
            GameManager.Instance.buyShopPopup(2);
        });
    }
}
