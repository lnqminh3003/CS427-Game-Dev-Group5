using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Energy : MonoBehaviour
{
    public TextMeshProUGUI amountText;

    float count = 0;
    float time = 5f;
    float defaultSpeed = 12;
    float defaultJump = 22;
    float defaultDash = 25;

    bool isCount = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (GameManager.Instance.fast <= 0) return;
            GameManager.Instance.fast -= 1;
            amountText.text = GameManager.Instance.fast.ToString();
            FindObjectOfType<PlayerController>().dashingPower = 40;
            FindObjectOfType<PlayerMovement>().m_AddVelocity_y = 30;
            FindObjectOfType<PlayerMovement>().speedMove = 16;
            isCount = true;
        }

        if (isCount)
        {
            count += Time.deltaTime;
            if(count >= time)
            {
                count = 0;
                isCount = false;
                FindObjectOfType<PlayerController>().dashingPower = defaultDash;
                FindObjectOfType<PlayerMovement>().m_AddVelocity_y = defaultJump;
                FindObjectOfType<PlayerMovement>().speedMove = defaultSpeed;
            }
        }
    }
}
