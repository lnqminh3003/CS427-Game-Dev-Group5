using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int coin = 300;
    public int health = 1;
    public int fast = 1;

    public void buyShop(int signal)
    {
        if(signal == 1)
        {
            if ( coin >= 200)
            {
                fast++;
                coin -= 200;
                FindObjectOfType<ShopController>().buySuccessPopup.SetActive(true);
                FindObjectOfType<UIShopController>().coinText.text = GameManager.Instance.coin.ToString();
            }
            else
            {
                FindObjectOfType<ShopController>().buyFailPopup.SetActive(true);
            }
        }
        else
        {
            if (coin >= 300)
            {
                health++;
                FindObjectOfType<ShopController>().buySuccessPopup.SetActive(true);
                coin -= 300;
                FindObjectOfType<UIShopController>().coinText.text = GameManager.Instance.coin.ToString();

            }
            else
            {
                FindObjectOfType<ShopController>().buyFailPopup.SetActive(true);
            }
        }
    }

    public void buyShopPopup(int signal)
    {
        if (signal == 1)
        {
            if (coin >= 200)
            {
                fast++;
                coin -= 200;
                FindObjectOfType<ShopPopupController>().buySuccessPopup.SetActive(true);
                FindObjectOfType<PlayerPoint>().UpdateHealth();
                FindObjectOfType<Energy>().amountText.text = fast.ToString();
            }
            else
            {
                FindObjectOfType<ShopPopupController>().buyFailPopup.SetActive(true);
            }
        }
        else
        {
            if (coin >= 300)
            {
                health++;
                FindObjectOfType<ShopPopupController>().buySuccessPopup.SetActive(true);
                coin -= 300;
                FindObjectOfType<PlayerPoint>().UpdateHealth();
            }
            else
            {
                FindObjectOfType<ShopPopupController>().buyFailPopup.SetActive(true);
            }
        }
    }
}
