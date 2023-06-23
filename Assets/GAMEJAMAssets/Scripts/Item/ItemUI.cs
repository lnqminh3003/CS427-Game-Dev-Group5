using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    public string id;
    Button button;
    bool isChoose = false;

    private void Start() {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClickButton);
        id = "0";
    }

    private void OnClickButton(){
        if(isChoose == false)
        {
            GetComponent<Image>().color = new Color(255,255,0);
            isChoose  = true;
        }
        else
        {
            GetComponent<Image>().color = new Color(255,255,255);
            isChoose  = false;
        }
    }
}
