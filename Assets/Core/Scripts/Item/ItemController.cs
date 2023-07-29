using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemController : MonoBehaviour
{
    private static ItemController instance;
    public GateController gateController;

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
    public GameObject successPopup;
    public GameObject failPopup;
    public GameObject InventoryPopup;
    public GameObject CompletePopup;
    public TextMeshProUGUI amountText;
    public ItemScriptableObject itemConfig;

    public Item[] listItemInScene;
    int totalItem => listItemInScene.Length;
    public GameObject[] ItemUI;

    public Dictionary<string, bool> listItem = new Dictionary<string, bool>();
    public Sprite transparentSprite;
    private bool isFirstSuccess;
    private bool isSecondSuccess;
    private bool isThirdSuccess;

    int currentItemGet = 0;
    int typeBox = 0;

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

    public void FillItemToInventory(int typeBox)
    {
        if (typeBox == 1 && ItemController.Instance.isFirstSuccess == true) return;
        if (typeBox == 2 && ItemController.Instance.isSecondSuccess == true) return;
        if (typeBox == 3 && ItemController.Instance.isThirdSuccess == true) return;

        InventoryPopup.SetActive(true);
        this.typeBox = typeBox;
        currentItemGet = 0;
        Debug.Log(typeBox);
        if (typeBox == 1 || typeBox == 2)
        {
            amountText.text = "NEED 3";
        }
        else
        {
            amountText.text = "NEED 4";
        }

        foreach (var child in ItemUI)
        {
            child.GetComponent<Image>().sprite = transparentSprite;
        }

        int index = 0;
        foreach (var child in listItem)
        {
            if (child.Value == true)
            {
                int indexItem = itemConfig.GetIndex(child.Key);
                int typeOfItem = itemConfig.types[indexItem];
                if (typeOfItem == typeBox)
                {
                    currentItemGet++;
                    ItemUI[index].gameObject.GetComponent<Image>().sprite = itemConfig.sprites[indexItem];
                    ItemUI[index].gameObject.transform.parent.transform.GetComponent<ItemUI>().id = child.Key;
                    index++;
                }
            }
        }
    }

    public void AddItem(string id)
    {
        listItem[id] = true;
    }

    public void ClassfyButton()
    {
        if (typeBox == 1 || typeBox == 2)
        {
            if (currentItemGet == 3)
            {
                if (typeBox == 2)
                {
                    isSecondSuccess = true;
                }
                else if (typeBox == 1)
                {
                    isFirstSuccess = true;
                }

                successPopup.SetActive(true);
            }
            else
            {
                failPopup.SetActive(true);
            }
        }
        else
        {
            if (currentItemGet == 4)
            {
                isThirdSuccess = true;
                successPopup.SetActive(true);
            }
            else
            {
                failPopup.SetActive(true);
            }
        }
    }

    private void Update()
    {
        if (isThirdSuccess == true && isSecondSuccess && isFirstSuccess)
        {
            gateController.OpenGate();
        }
    }
}
