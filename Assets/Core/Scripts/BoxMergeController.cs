using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMergeController : MonoBehaviour
{
    public bool colliderButton =  false;
    public bool isBox = false;
    public int typeBox;
    private void Start() {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player" && colliderButton)
        {
            LevelController.Instance.OpenPopupInventory(typeBox);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
         if(other.gameObject.tag == "Button")
        {
            colliderButton = true;
            Destroy(other.gameObject);
            LevelController.Instance.OpenPopupInventory(typeBox);
        }
    }
}
