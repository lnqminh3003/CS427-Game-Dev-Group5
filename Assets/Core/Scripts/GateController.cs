using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    public void OpenGate()
    {
        gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
    }
}
