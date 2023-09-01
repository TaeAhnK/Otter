using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyOtter : MonoBehaviour
{
    private GameLogic gameLogic;

    private void Awake()
    {
        gameLogic = GameObject.FindWithTag("Logic").GetComponent<GameLogic>();
    }

    private void Update()
    {
    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameLogic.babyOtter = true;
            Destroy(gameObject); // 아이템을 획득하면 아이템 제거
        }
    }

    // public Otter otter; // 플레이어 오브젝트인 Otter의 참조를 받는 변수
    // public float defaultDuration = 5f; // 아이템 효과 지속 시간 기본값
    // public float maxDuration = 10f;     // 아이템 효과 지속 시간 최대값
    // public float zMovementSpeed = 1f;   // 아기해달 위치의 Z값이 커지는 속도

    // public GameObject babyOtterPrefab; // 새끼해달 프리팹

    // private bool isEffectActive = false; // 아이템 효과가 활성화되었는지 여부


    // public void ApplyEffect()
    // {
    //     // 아기해달 생성 및 배치
    //     GameObject babyOtterObj = Instantiate(babyOtterPrefab, transform.position, Quaternion.identity);
    //     BabyOtter babyOtter = babyOtterObj.GetComponent<BabyOtter>();
    //     babyOtter.otter = this.otter; // otter 변수 대신에 this.otter 사용

    //     // 듀얼샷 공격 활성화
    //     otter.EnableDualShot();

    //     // 아기해달 적용 시간이 끝나면 아이템 효과 종료
    //     StartCoroutine(DeactivateBabyOtterEffect());
    // }

    // private IEnumerator DeactivateBabyOtterEffect()
    // {
    //     yield return new WaitForSeconds(defaultDuration);

    //     // 듀얼샷 비활성화
    //     otter.DeactivateBabyOtterEffect();

    //     // 아기해달 제거
    //     Transform babyOtterTransform = transform.Find("BabyOtter(Clone)");
    //     if (babyOtterTransform != null)
    //     {
    //         Destroy(babyOtterTransform.gameObject);
    //     }
    // }



    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag("Player"))
    //     {
    //         ApplyEffect();
    //         StartCoroutine(DeactivateBabyOtterEffect());
    //         Destroy(gameObject); // 아이템을 획득하면 아이템 제거
    //     }
    // }



    // // TODO: 레벨 업 시 아이템 효과 지속 시간 증가 로직 추가

    // private void Update()
    // {
    //     if (isEffectActive)
    //     {
    //         // 아기해달 위치의 Z값을 시간이 지남에 따라 증가시킴
    //         float newZ = transform.position.z + zMovementSpeed * Time.deltaTime;
    //         transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
    //     }
    // }
}
