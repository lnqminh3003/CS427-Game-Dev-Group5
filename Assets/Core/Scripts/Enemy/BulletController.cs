using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;

    private void Start()
    {
    }

    private void Update()
    {
        transform.Translate(-Vector2.right * speed* Time.deltaTime);
    }
}
