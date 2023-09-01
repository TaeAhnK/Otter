using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health;
    private float minZ = -6f;

    private GameLogic gameLogic;
    public GameObject item;

    void Start()
    {
        gameLogic = GameObject.FindWithTag("Logic").GetComponent<GameLogic>();
    }

    void Update()
    {
        transform.position += Vector3.back * gameLogic.getEnemySpeed() * Time.deltaTime;
        if (transform.position.z < minZ)
        {
            Destroy(gameObject);
        }   //when enemy falls below minZ the enemy will be gone
    }

    //충돌처리 태그가 웨폰으로 되어있는 것과 충돌하면 적의 hp가 깎임
    private void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.CompareTag("Shell"))
        {
            health -= 50;                    //총알데미지 만큼 적 피 깎임
            Destroy(collide.gameObject);
            if (health <= 0)                 // 적 체력 0되면 적 사라지고 아이템 드랍, 스코어상승
            {
                Destroy(gameObject);
                gameLogic.addScore(10);
                Instantiate(item, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            }
        }
    }
}