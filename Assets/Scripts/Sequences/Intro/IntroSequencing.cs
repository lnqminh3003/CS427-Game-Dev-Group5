using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroSequencing : MonoBehaviour {

    public GameObject textBox;
    public GameObject dateDisplay;
    public GameObject placeDisplay;
    public AudioSource line01;
    public AudioSource line02;
    public AudioSource line03;
    public AudioSource line04;
    public AudioSource line05;
    public AudioSource thudSound;
    public GameObject allBlack;
    public GameObject loadText;

    void Start () {
        StartCoroutine(SequenceBegin());
	}

    IEnumerator SequenceBegin()
    {
        yield return new WaitForSeconds(3);
        placeDisplay.SetActive(true);
        yield return new WaitForSeconds(1);
        dateDisplay.SetActive(true);
        yield return new WaitForSeconds(4);
        placeDisplay.SetActive(false);
        dateDisplay.SetActive(false);
        yield return new WaitForSeconds(10);
        textBox.GetComponent<Text>().text = "The night of October 29th 2008 changed me forever.";
        line01.Play();
        yield return new WaitForSeconds(4.5f);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "I headed out to investigate the haunting sounds in the woods.";
        line02.Play();
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(7);
        textBox.GetComponent<Text>().text = "I stumbled upon a clearing with a cabin in the distance.";
        line03.Play();
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "I could hear those sounds again coming from there.";
        line04.Play();
        yield return new WaitForSeconds(4);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(6);
        textBox.GetComponent<Text>().text = "Little did I know that this was only the beginning.";
        line05.Play();
        yield return new WaitForSeconds(4);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(17);
        allBlack.SetActive(true);
        thudSound.Play();
        yield return new WaitForSeconds(1);
        loadText.SetActive(true);
        SceneManager.LoadScene(2);
    }




}
