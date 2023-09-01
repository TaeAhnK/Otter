using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otter : MonoBehaviour
{
    public GameObject gameLogic;

    private float deadX = 7f;

    void Awake()
    {

    }

    void Start()
    {

    }

    void Update()
    {
        DragMovement();
    }

    private void OnTriggerEnter(Collider collide)
    {
        // Collision with Enemy
        if (collide.gameObject.CompareTag("Enemy"))
        {
            gameLogic.GetComponent<GameLogic>().addOtterLife(-1);
            Debug.Log("Otter Hit Enemy: " + gameLogic.GetComponent<GameLogic>().getOtterLife());
        }

        // Collision with Reef
        if (collide.gameObject.CompareTag("Reef"))
        {
            gameLogic.GetComponent<GameLogic>().addOtterLife(-1);
            Debug.Log("Otter Hit Reef: " + gameLogic.GetComponent<GameLogic>().getOtterLife());
        }

        // Collision with Item
        // if (collide.gameObject.CompareTag("Item"))
        // {
        //     Debug.Log("Otter Hit Item");
        // }
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

    // When Dies
    public void OtterDeath()
    {
        Debug.Log("Otter Death");
    }

    // private void ApplyItemEffect(GameObject item)
    // {
    //     // 아이템 종류에 따라 적절한 효과 스크립트 가져오기
    //     BabyOtter babyOtterEffect = item.GetComponent<BabyOtter>();
    //     DoubleScoreItem doubleScoreEffect = item.GetComponent<DoubleScoreItem>();
    //     HyperWaveItem hyperWaveEffect = item.GetComponent<HyperWaveItem>();
    //     WhirlpoolItem whirlpoolEffect = item.GetComponent<WhirlpoolItem>();

    //     // 아이템 종류에 따라 해당 효과 적용
    //     if (babyOtterEffect != null)
    //     {
    //         babyOtterEffect.ApplyEffect();
    //     }
    //     else if (doubleScoreEffect != null)
    //     {
    //         doubleScoreEffect.ApplyEffect();
    //     }
    //     else if (hyperWaveEffect != null)
    //     {
    //         hyperWaveEffect.ApplyEffect();
    //     }
    //     else if (whirlpoolEffect != null)
    //     {
    //         whirlpoolEffect.ApplyEffect();
    //     }
    // }
}