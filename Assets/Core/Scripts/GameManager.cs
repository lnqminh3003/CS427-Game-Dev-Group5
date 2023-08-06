using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int coin = 300;
    public int health = 1;
    public int fast = 0;

    public void buyShop(int signal)
    {
        if(signal == 1)
        {
            if ( coin >= 500)
            {
                fast++;
                coin -= 500;
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
            if (coin >= 200)
            {
                health++;
                FindObjectOfType<ShopController>().buySuccessPopup.SetActive(true);
                coin -= 200;
                FindObjectOfType<UIShopController>().coinText.text = GameManager.Instance.coin.ToString();

            }
            else
            {
                FindObjectOfType<ShopController>().buyFailPopup.SetActive(true);
            }
        }
    }
}
