using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public GameObject popupYouDie;
    public bool isDie = false;

    public GameObject EffectJump;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            AudioManager.instance.PlaySfx("kill");
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Obstacle")
        {
            GetComponent<PlayerController>().UpdateAnimation();
            StartCoroutine(deplay());
            popupYouDie.SetActive(true);
            TutorialSceneController.Instance.TutorialText.gameObject.SetActive(false);
            AudioManager.instance.PlaySfx("die");
            isDie = true;
        }
    }

    IEnumerator deplay(){
        yield return new WaitForSeconds(2f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            AudioManager.instance.PlaySfx("kill");
            Destroy(other.gameObject.transform.parent.gameObject);
        }
        else if (other.gameObject.tag == "ChainSaw")
        {
            AudioManager.instance.PlaySfx("die");
            GetComponent<PlayerController>().UpdateAnimation();
            StartCoroutine(deplay());
            isDie = true;
            popupYouDie.SetActive(true);
        }
    }
}
