using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour {

    public GameObject fadeOut;
    public GameObject loadText;
    public AudioSource buttonClick;

    public void NewGameButton()
    {
        StartCoroutine(NewGameStart());
    }

    IEnumerator NewGameStart()
    {
        fadeOut.SetActive(true);
        buttonClick.Play();
        yield return new WaitForSeconds(3);
        loadText.SetActive(true);
        SceneManager.LoadScene(4);
    }

}
