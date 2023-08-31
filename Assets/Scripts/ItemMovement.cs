using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour
{
    private float deadZ = -6;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.forward * -3f * Time.deltaTime);
        if (transform.position.z < deadZ)
        {
            Destroy(gameObject);
        }
    }
}
