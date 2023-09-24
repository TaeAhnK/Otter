using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowShell : MonoBehaviour
{
    public float speed = 100; //이동속도
    private float deadZ = 50f;
    void Start()
    {

    }

    void Update()
    {
        Vector3 dir = Vector3.forward; //방향 구하기
        transform.position += dir * speed * Time.deltaTime; //컴퓨터 성능에 구애받지 않고 이동

        if (transform.position.z > deadZ)
        {
            Destroy(gameObject);
        }
    }
}
