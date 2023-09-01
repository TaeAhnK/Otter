using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShellEffect : MonoBehaviour
{
    GameLogic logic; //게임로직 적용
    EnemySpawner es; //에너미스포너 적용
    public GameObject item; //아이템 참조
    
    // Start is called before the first frame update
    void Start()
    {
        logic=FindObjectOfType<GameLogic>(); //게임로직 클래스 불러오기
        es=FindObjectOfType<EnemySpawner>(); // 에너미스포너 클래스 불러오기
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.tag=="Enemy") //총알이 적을 맞추면
        {
            Destroy(this.gameObject);        //총알사라짐
            logic.getEnemyDamage();          //총알데미지 만큼 적 피 깎임
            if (logic.enemyLife <= 0)        // 적 체력 0되면 적 사라지고 아이템 드랍, 스코어상승
            {
                Destroy(collide.gameObject);
                logic.addScore(10);
                Instantiate(item, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            }
        }
    }
}
