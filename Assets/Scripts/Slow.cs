using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow : MonoBehaviour
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
            gameLogic.slow = true;
            Destroy(gameObject); // 아이템을 획득하면 아이템 제거
        }
    }
}
