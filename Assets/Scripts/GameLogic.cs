using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public GameObject otter;        // Otter Object
    public GameObject enemySpawner; // Enemy Spawner
    public GameObject reefSpawner;  // Reef Spawner

    private int score;              // Score

    // Otter Info
    private int otterLife;          // Otter Life
    private int otterEXP;

    // Enemy Info
    private float enemySpeed;       // Enemy Move Speed
    private float reefSpeed;        // Rate Move Speed

    // Item Activation
    bool babyOtter;                 // Dual Shot
    bool hyperWave;                 // Invinsible
    bool seaWirl;                   // Magnet
    bool slow;                      // Slow enemy and reef
    bool doubleScore;               // Gets double score


    private float minSpawnDelay = 10f; // 적 생성 간격의 최소값
    private float maxSpawnDelay = 15f;// 적 생성 간격의 최대값
    private float nextSpawnTime; // 다음 적 생성 시 


    void Start()
    {
        SetNextSpawnTime();
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            StartEnemySpawning(); // Start spawning enemies using EnemySpawner.
            SetNextSpawnTime();
        }

    }

    public int getScore()
    {
        return score;
    }

    public int getOtterLife()
    {
        return otterLife;
    }

    public int getOtterEXP()
    {
        return otterEXP;
    }

    public void addScore(int add)
    {
        score += add;
    }

    public void addOtterLife(int add)
    {
        otterLife += add;
    }

    public void addOtterEXP(int add)
    {
        otterEXP += add;
    }

    public Vector3 currentOtterPosition()
    {
        return otter.transform.position;
    }

    public void setEnemySpeed(float speed)
    {
        SetEnemySpeedInSpawner(speed);
        //SetEnemySpeedInSpawner 함수를 호출하여 EnemySpawner 내부에 있는 적의 이동 속도도 업데이트
        enemySpeed = speed;
    }

    public float getReefSpeed()
    {
        return reefSpeed;
    }

    public void setReefSpeed(float speed)
    {
        reefSpeed = speed;
    }

    private void spawnEnemy()
    {
        
    }
    private void StartEnemySpawning()
    {
        enemySpawner.GetComponent<EnemySpawner>().StartEnemyRoutine(); //  // EnemySpawner를 이용하여 적 생성
        SetEnemySpeedInSpawner(enemySpeed); // 적 생성을 시작하면서 동시에 적의 이동 속도도 업데이트
    }
    private void SetNextSpawnTime()
    {
        float randomDelay = Random.Range(minSpawnDelay, maxSpawnDelay);
        nextSpawnTime = Time.time + randomDelay;  
        // 랜덤한 딜레이 값을 계산하여 다음 적 생성 시간을 설정
        // 생성되는 적의 간격을 랜덤하게 조절
    }

    private void SetEnemySpeedInSpawner(float speed)
    {
        enemySpawner.GetComponent<EnemySpawner>().SetEnemySpeed(speed);
        // EnemySpawner 컴포넌트를 가져와서 적의 이동 속도를 업데이트
        // EnemySpawner 클래스 내부의 SetEnemySpeed 함수를 호출하여 실제로 적의 이동 속도를 변경
    }

    private void spawnReef()
    {

    }

    private void spawnBoss()
    {

    }
}