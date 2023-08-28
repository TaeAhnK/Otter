using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 30; // 기본이동속도
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); //좌우 이동버튼
        Vector3 dir = new Vector3(h, 0, 0); // 버튼을 받는 변수에 따라 정하는 방향 변수
        transform.position += dir *speed * Time.deltaTime; // 성능 상관없이 균일하게 플레이어 이동
    }
}
