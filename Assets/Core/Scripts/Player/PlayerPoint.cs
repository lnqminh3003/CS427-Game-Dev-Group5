using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPoint : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public GameObject health1;
    public GameObject health2;
    public GameObject health3;

    private void Start()
    {
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        coinText.text = GameManager.Instance.coin.ToString();
        if (GameManager.Instance.health == 1)
        {
            health2.SetActive(false);
            health3.SetActive(false);
        }
        else if (GameManager.Instance.health == 2)
        {
            health3.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Diamond")
        {
            ItemController.Instance.AddItem(other.GetComponent<Item>().id);
            Destroy(other.gameObject);
            AudioManager.instance.PlaySfx("collect");
        }
        else if(other.tag =="Trigger1" && TutorialSceneController.Instance.index == 0)
        {
            TutorialSceneController.Instance.index ++;
            TutorialSceneController.Instance.TutorialText.text =  TutorialSceneController.Instance.Tutorial[TutorialSceneController.Instance.index];
        }
        else if(other.tag =="Trigger2" && TutorialSceneController.Instance.index == 1)
        {
            TutorialSceneController.Instance.index ++;
            TutorialSceneController.Instance.TutorialText.text =  TutorialSceneController.Instance.Tutorial[TutorialSceneController.Instance.index];
        }
        else if(other.tag =="Trigger3" && TutorialSceneController.Instance.index == 2)
        {
            TutorialSceneController.Instance.index ++;
            TutorialSceneController.Instance.TutorialText.text =  TutorialSceneController.Instance.Tutorial[TutorialSceneController.Instance.index];
        }
        else if(other.tag =="Trigger4")
        {
            TutorialSceneController.Instance.TutorialText.gameObject.SetActive(false);
            TutorialSceneController.Instance.popupCollection.SetActive(true);
        }
        else if(other.tag =="Trigger5")
        {
            TutorialSceneController.Instance.popupCollection.SetActive(false);
        }
        else if (other.tag == "Gate")
        {
            Destroy(other.gameObject);
            AudioManager.instance.PlaySfx("kill");
        }
        else if (other.tag == "Coin")
        {
            Destroy(other.gameObject);
            GameManager.Instance.coin += 50;
            coinText.text = GameManager.Instance.coin.ToString();
            AudioManager.instance.PlaySfx("collect");
        }
    }
}
