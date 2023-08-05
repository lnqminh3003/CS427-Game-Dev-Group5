using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabController : MonoBehaviour
{
    public GameObject spawnBullet;
    public BulletController bullet;
    public float time;
    float count = 0;

    private void FixedUpdate()
    {
        count += Time.deltaTime;
        if(count >= time)
        {
            count = 0;
            Instantiate(bullet, spawnBullet.transform);
        }
    }
}
