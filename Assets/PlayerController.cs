using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 플레이어 이동 속도
    public float moveSpeed = 5f;

    private void Update()
    {
        // 마우스 클릭으로 플레이어 이동
        if (Input.GetMouseButton(0))
        {
            // 현재 마우스 위치를 월드 좌표로 변환
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = transform.position.z; // 현재 Z 위치 유지

            // 플레이어를 목표 위치로 이동
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }


    // 싱글톤 인스턴스
    private static PlayerController instance;
    public static PlayerController Instance { get { return instance; } }

    // ...

    private void Awake()
    {
        // 싱글톤 인스턴스 설정
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private bool isDualShotEnabled = false; // 듀얼샷 활성화 여부

    // ...

    // 듀얼샷 활성화 메서드
    public void EnableDualShot()
    {
        isDualShotEnabled = true;
        // TODO: 듀얼샷 활성화에 관련된 로직을 추가하십시오.
    }

    // 듀얼샷 비활성화 메서드
    public void DisableDualShot()
    {
        isDualShotEnabled = false;
        // TODO: 듀얼샷 비활성화에 관련된 로직을 추가하십시오.
    }

    // 듀얼샷 활성화 여부 반환 메서드
    public bool IsDualShotEnabled()
    {
        return isDualShotEnabled;
    }

    // ...
}