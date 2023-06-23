using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPoint : MonoBehaviour
{
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
    }
}
