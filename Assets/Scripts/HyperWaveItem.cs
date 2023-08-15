using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperWaveItem : MonoBehaviour
{
    public float defaultDuration = 5f; // 아이템 효과 지속 시간 기본값
    public float maxDuration = 10f;     // 아이템 효과 지속 시간 최대값
    public float zMovementSpeed = 1f;   // 아이템 위치의 Z값이 커지는 속도

    public GameObject hyperWaveEffect; // 파동 이펙트 프리팹
    public GameObject whirlpoolEffect; // 급류 이펙트 프리팹 (다른 효과에 따라 바꿀 수 있음)

    private bool isEffectActive = false; // 아이템 효과가 활성화되었는지 여부

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ApplyHyperWaveEffect();
            StartCoroutine(DeactivateHyperWaveEffect());
            Destroy(gameObject); // 아이템을 획득하면 아이템 제거
        }
    }

    private void ApplyHyperWaveEffect()
    {
        // 급류 이펙트 활성화
        whirlpoolEffect.SetActive(true);
        isEffectActive = true;

        // TODO: 돌진 및 무적 효과 적용 로직

        // 시간에 따라 아이템 위치의 Z값을 변화시키는 코루틴 실행
        StartCoroutine(MoveZPositionOverTime());
    }

    private IEnumerator MoveZPositionOverTime()
    {
        while (isEffectActive)
        {
            float newZ = transform.position.z + zMovementSpeed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
            yield return null;
        }
    }

    private IEnumerator DeactivateHyperWaveEffect()
    {
        yield return new WaitForSeconds(defaultDuration); // 아이템 효과 지속 시간만큼 대기

        // 파동 이펙트 활성화
        hyperWaveEffect.SetActive(true);

        // TODO: 파동 효과 및 소멸 로직 구현

        // 급류 이펙트 비활성화
        whirlpoolEffect.SetActive(false);
        isEffectActive = false;
    }

    // TODO: 레벨 업 시 아이템 효과 지속 시간 증가 로직 추가
}
