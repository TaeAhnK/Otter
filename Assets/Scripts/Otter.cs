using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otter : MonoBehaviour
{
    private static Otter instance;
    public static Otter Instance { get { return instance; } }

    private float deadX = 7f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        DragMovement();
    }

    private void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Otter Hit Enemy");
        }

        if (collide.gameObject.CompareTag("Reef"))
        {
            Debug.Log("Otter Hit Reef");
        }

        if (collide.gameObject.CompareTag("Item"))
        {
            Debug.Log("Otter Hit Item");
        }
    }

    // Drag Movement
    private void DragMovement()
    {
        if (Input.touchCount > 0)
        {
            //Debug.Log(0.01f * Input.GetTouch(0).position.x);
            transform.position = new Vector3((Input.GetTouch(0).position.x - Screen.width / 2) * (deadX / Screen.width), 0, 0);
        }
    }

    public void EnableDualShot()
    {
        Debug.Log("Dual shot is activated");
        // TODO: 듀얼샷 활성화에 관련된 로직을 추가해야함
    }

    public void DeactivateBabyOtterEffect()
    {
        Debug.Log("Dual shot is deactivated");
        // TODO: 듀얼샷 비활성화에 관련된 로직을 추가해야함
    }

    private void ApplyItemEffect(GameObject item)
    {
        // 아이템 종류에 따라 적절한 효과 스크립트 가져오기
        BabyOtter babyOtterEffect = item.GetComponent<BabyOtter>();
        DoubleScoreItem doubleScoreEffect = item.GetComponent<DoubleScoreItem>();
        HyperWaveItem hyperWaveEffect = item.GetComponent<HyperWaveItem>();
        WhirlpoolItem whirlpoolEffect = item.GetComponent<WhirlpoolItem>();

        // 아이템 종류에 따라 해당 효과 적용
        if (babyOtterEffect != null)
        {
            babyOtterEffect.ApplyEffect();
        }
        else if (doubleScoreEffect != null)
        {
            doubleScoreEffect.ApplyEffect();
        }
        else if (hyperWaveEffect != null)
        {
            hyperWaveEffect.ApplyEffect();
        }
        else if (whirlpoolEffect != null)
        {
            whirlpoolEffect.ApplyEffect();
        }
    }
}