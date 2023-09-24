using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject item;
    private float timer;
    private float shootingRate = 1f;

    void Start()
    {
        timer = 0.0f;
    }

    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (timer > shootingRate)
        {
            Instantiate(item, transform.position, transform.rotation);
            timer = 0f;
        }
        timer += Time.deltaTime;
    }
}
