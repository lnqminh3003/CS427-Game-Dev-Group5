using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (ItemController.Instance.CheckOk())
            {
                UILevel1Controller.Instance.LevelCompletePopup.gameObject.SetActive(true);
            }
            else
            {
                UILevel1Controller.Instance.FailPopup.gameObject.SetActive(true);
            }
            
        }
    }
}
