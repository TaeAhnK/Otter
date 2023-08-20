using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReefMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.back * moveSpeed) * Time.deltaTime;
        
        //파이프가 일정 구간 넘어가면(deadZone) 암초를 없앰
        if (transform.position.z<deadZone)
        {
            Destroy(gameObject);
        }
    }
}
