using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;

    private float minZ = -6f;

    [SerializeField]
    //private float hp = 1f;//(set enemy hp)

    void Start()
    {

    }


    void Update()
    {
        transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        if (transform.position.z < minZ)
        {
            Destroy(gameObject);
        }//when enemy falls below minZ the enemy will be gone
        

    //충돌처리  태그가 웨폰으로 되어있는 것과 충돌하면 적의 hp가 깎임

    //private void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.gameObject.tag == "Weapon")
    //     {
    //         Weapon weapon = other.gameobject.GetComponent<weapon>();
    //         hp -= weapon.damage;
    //         if (hp <= 0)
    //         {
    //             Destroy(gameObject);
    //         }

    //    }
    }

}