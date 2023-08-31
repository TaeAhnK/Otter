using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;

    // 적 위치
    private float[] arrPosX = { -3f, -1.5f, 0f, 1.5f, 3f };

    // enemy spawn speed
    [SerializeField] public float spawnInterval = 3f;


    void Start()
    {
        StartEnemyRoutine();
    }

    public void StartEnemyRoutine()
    {
        StartCoroutine("EnemyRoutine");
    }

    void Update()
    {

    }

    IEnumerator EnemyRoutine()
    {
        yield return new WaitForSeconds(2);

        int spawnCount = 0;
        int enemyIndex = 0;

        while (true)
        {
            foreach (float posX in arrPosX)
            {
                SpawnEnemy(posX, enemyIndex);

            }

            spawnCount += 1;
            if (spawnCount % 10 == 0) //10번씩 나옴
            {
                enemyIndex += 1;
            }

            yield return new WaitForSeconds(spawnInterval);
        }


    }

    void SpawnEnemy(float posX, int index)
    {
        Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);

        if (Random.Range(0, 5) == 0)//0,1,2,3,4 -> 0 (20% next enemy appear)
        {
            index += 1;
        }


        //적의 수를 넘어가지않게 오류 방지 (max enemy 5)
        if (index >= enemies.Length)
        {
            index = enemies.Length - 1;
        }

        Instantiate(enemies[index], spawnPos, Quaternion.identity);



    }
}

//enemy1이 제일 약한 적, enemy5가 가장 쎈 적
//Enemies 1 to 5 come out 10 times in order, the next enemy are mixed in 20% probability

