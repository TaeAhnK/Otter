using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyOtter : MonoBehaviour
{
    public float defaultDuration = 5f; // 아이템 효과 지속 시간 기본값
    public float maxDuration = 10f;     // 아이템 효과 지속 시간 최대값
    public float zMovementSpeed = 1f;   // 아기해달 위치의 Z값이 커지는 속도

    public GameObject babyOtterPrefab; // 새끼해달 프리팹

    private bool isEffectActive = false; // 아이템 효과가 활성화되었는지 여부

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ApplyBabyOtterEffect();
            StartCoroutine(DeactivateBabyOtterEffect());
            Destroy(gameObject); // 아이템을 획득하면 아이템 제거
        }
    }

    private void ApplyBabyOtterEffect()
    {
        // 새끼해달 생성 및 배치
        GameObject babyOtter = Instantiate(babyOtterPrefab, transform.position, Quaternion.identity);
        babyOtter.transform.parent = PlayerController.Instance.transform;

        // TODO: 듀얼샷 공격 로직
        PlayerController.Instance.EnableDualShot(); // 듀얼샷 활성화

        // 아기해달 적용 시간이 끝나면 아이템 효과 종료
        StartCoroutine(DeactivateBabyOtterEffect());
    }

    private IEnumerator DeactivateBabyOtterEffect()
    {
        yield return new WaitForSeconds(defaultDuration); // 아이템 효과 지속 시간만큼 대기

        // TODO: 아이템 효과 종료 로직

        // 듀얼샷 비활성화
        PlayerController.Instance.DisableDualShot();
        // 아기해달 제거
        Transform babyOtterTransform = PlayerController.Instance.transform.Find("BabyOctopus(Clone)");
        if (babyOtterTransform != null)
        {
            Destroy(babyOtterTransform.gameObject);
        }
    }
    // TODO: 레벨 업 시 아이템 효과 지속 시간 증가 로직 추가

    private void Update()
    {
        if (isEffectActive)
        {
            // 아기해달 위치의 Z값을 시간이 지남에 따라 증가시킴
            float newZ = transform.position.z + zMovementSpeed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
        }
    }
}
