using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemies;

    // 적 위치 배열
    private float[] arrPosX = { -3f, -1.5f, 0f, 1.5f, 3f };

    [SerializeField]
    public float spawnInterval = 5f;//적의 생성 간격

    private float enemySpeed = 5f;//적의 초기 이동 속도 설정
    private float nextSpawnTime;
    private int spawnCount = 0;
    private int enemyIndex = 0;


    void Start()
    {
        SetNextSpawnTime(); //초기 생성 간격 설정
        StartEnemyRoutine(); //첫번째 적 생성 루틴 시작
    }

    public void StartEnemyRoutine()
    {
        StartCoroutine("EnemyRoutine"); // 적생성 루틴 시작 
    }

    IEnumerator EnemyRoutine()
    {
        yield return new WaitForSeconds(2); //시작 후 2초 대기


        while (true)
        {
            foreach (float posX in arrPosX)
            {
                SpawnEnemy(posX, enemyIndex); //적 생성 함수 호출

            }
            spawnCount += 1;
            if (spawnCount % 10 == 0) //적 10번씩 생성
            {
                enemyIndex += 1;
            }

            yield return new WaitForSeconds(spawnInterval); // 다음 적 생성까지 간격 대기
        }


    }




    void SpawnEnemy(float posX, int index)
    {
        Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);

        if (Random.Range(0, 5) == 0)//0,1,2,3,4 -> 0 (20% next enemy appear)
        {
            index += 1;
        }
        if (index >= enemies.Length)
        {
            index = enemies.Length - 1; // 인덱스가 적의 배열 범위를 벗어나지 않도록 설정
        }

        Instantiate(enemies[index], spawnPos, Quaternion.identity); //적 생성
    }




    private void SetNextSpawnTime()
    {
        nextSpawnTime = Time.time + spawnInterval; //다음 적 생성 시간 설정
    }

    public void SetEnemySpeed(float speed)
    {
        enemySpeed = speed; //적의 이동속도 설정
    }

    void Update()
    {

    }

}