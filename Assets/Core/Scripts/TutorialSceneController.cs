using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TutorialSceneController : MonoBehaviour
{
    private static TutorialSceneController instance;

    public static TutorialSceneController Instance{
        get{
            if (instance == null) 
            {
                instance = FindObjectOfType<TutorialSceneController>(true);
            }
             return instance;
        }
    }

    private void Awake() {
        if(instance != null)
        {
            Destroy(instance.gameObject);
        }
        instance = this;
    }
    public TextMeshProUGUI TutorialText ;
    public GameObject popupCollection ;
    public List<string> Tutorial =  new List<string>();
    public int index; 

    private void Start() {
        index = 0;
        TutorialText.text =  Tutorial[0];
    }
}
