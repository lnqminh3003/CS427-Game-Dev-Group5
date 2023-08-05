using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemController : MonoBehaviour
{
    private static ItemController instance;
    public static ItemController Instance => instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(instance.gameObject);
        }
        instance = this;
    }

    [Header("Popup")]
    public ItemScriptableObject itemConfig;

    public Item[] listItemInScene;
    int totalItem => listItemInScene.Length;
    public GameObject[] ItemUI;

    public Dictionary<string, bool> listItem = new Dictionary<string, bool>();
    public Sprite transparentSprite;


    private void OnValidate()
    {
        listItemInScene = FindObjectsOfType<Item>();
    }

    private void Start()
    {
        for (int i = 0; i < itemConfig.ids.Length; i++)
        {
            listItem.Add(itemConfig.ids[i], false);
        }
    }

    public void FillItemToInventory()
    {
        foreach(var child in ItemUI)
        {
            child.GetComponent<Image>().sprite = transparentSprite;
        }

        int index = 0;
        foreach (var child in listItem)
        {
            if (child.Value == true)
            {
                ItemUI[index].GetComponent<Image>().sprite = itemConfig.sprites[itemConfig.GetIndex(child.Key)];
                index++;
            }
        }        
    }

    public void AddItem(string id)
    {
        listItem[id] = true;
    }

    public bool CheckOk()
    {
        foreach(var child in listItem)
        {
            if(child.Value == false)
            {
                return false;
            }
        }
        return true;
    }
}
