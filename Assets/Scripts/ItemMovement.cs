using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.forward * -3f * Time.deltaTime);
    }
}
