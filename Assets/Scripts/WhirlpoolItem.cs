using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhirlpoolItem : MonoBehaviour
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
        if (other.CompareTag("Otter"))
        {
            gameLogic.seaWirl = true;
            Destroy(gameObject); // 아이템을 획득하면 아이템 제거
        }
    }


    // public float defaultDuration = 5f; // 아이템 효과 지속 시간 기본값
    // public float maxDuration = 10f;     // 아이템 효과 지속 시간 최대값
    // public float defaultRadius = 5f;   // 효력이 발생하는 범위 기본값
    // public float maxRadiusIncrease = 0.5f; // 범위 증가 최대 값

    // public GameObject whirlpoolEffect; // 회오리 이펙트 프리팹

    // private bool isEffectActive = false; // 아이템 효과가 활성화되었는지 여부
    // private float currentRadius; // 현재 효과 범위

    // private void Start()
    // {
    //     currentRadius = defaultRadius;
    // }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag("Player"))
    //     {
    //         ApplyEffect();
    //         StartCoroutine(DeactivateWhirlpoolEffect());
    //         Destroy(gameObject); // 아이템을 획득하면 아이템 제거
    //     }
    // }

    // public void ApplyEffect()
    // {
    //     // 회오리 이펙트 활성화
    //     whirlpoolEffect.SetActive(true);
    //     isEffectActive = true;

    //     // TODO: 주변에 있는 먹이와 아이템을 끌어들이는 로직
    //     StartCoroutine(IncreaseRadiusOverTime());
    // }

    // private IEnumerator IncreaseRadiusOverTime()
    // {
    //     while (isEffectActive && currentRadius < defaultRadius + maxRadiusIncrease)
    //     {
    //         currentRadius += maxRadiusIncrease * Time.deltaTime;
    //         yield return null;
    //     }
    // }

    // private IEnumerator DeactivateWhirlpoolEffect()
    // {
    //     yield return new WaitForSeconds(defaultDuration); // 아이템 효과 지속 시간만큼 대기

    //     // 회오리 이펙트 비활성화
    //     whirlpoolEffect.SetActive(false);
    //     isEffectActive = false;

    //     // TODO: 끌어들이는 효과 해제 로직
    // }

    // // TODO: 레벨 업 시 아이템 효과 지속 시간 및 범위 증가 로직 추가
}
