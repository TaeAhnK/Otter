using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemies;

    // 적위치
    private float[] arrPosX = { -3f, -1.5f, 0f, 1.5f, 3f };

    [SerializeField]
    private float spawnInterval = 1.5f;


    void Start()
    {
        StartEnemyRoutine();

    }

    void StartEnemyRoutine()
    {
        StartCoroutine("EnemyRoutine");
    }

    IEnumerator EnemyRoutine()
    {
        yield return new WaitForSeconds(2f);

        int spawnCount = 0;

        while (true)
        {
            List<int> selectedPositions = new List<int>();
            while (selectedPositions.Count <3)
            {
                int randomPositionIndex = Random.Range(0, arrPosX.Length);
                if (!selectedPositions.Contains(randomPositionIndex))
                {
                    selectedPositions.Add(randomPositionIndex);
                }
            }

            foreach (int positionIndex in selectedPositions)
            {
                int randomEnemyIndex = Random.Range(1, 5); // 1부터 4 사이의 랜덤한 인덱스 선택
                float randomPosX = arrPosX[positionIndex]; // 선택한 위치 인덱스에 해당하는 X 위치

                SpawnEnemy(randomPosX, randomEnemyIndex);
            }



            spawnCount += 1;
            if (spawnCount % 10 == 0) // 10번마다 적 종류 변경
            {
               
            }

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnEnemy(float posX, int index)
    {
        Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);

     


           

        Instantiate(enemies[index], spawnPos, Quaternion.identity);
    }




    void Update()
    {

    }
}

//enemy1이 제일 약한 적    ㄱ    enemy5가 가장 쎈 적
//순서대로 10번씩 나오는데 20%확률로 다른 적들이 섞여서 나

