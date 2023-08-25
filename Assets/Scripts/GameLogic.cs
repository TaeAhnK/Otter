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
    private float nextSpawnTime;

    void Start()
    {
        SetNextSpawnTime();
        otterLife = 3;
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            enemySpawner.GetComponent<EnemySpawner>().StartEnemyRoutine(); // Start spawning enemies using EnemySpawner.
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

    public float getEnemySpeed()
    {
        return enemySpeed;
    }

    public void setEnemySpeed(float speed)
    {
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

    private void SetNextSpawnTime()
    {
        float randomDelay = Random.Range(minSpawnDelay, maxSpawnDelay);
        nextSpawnTime = Time.time + randomDelay; // Set the time for the next enemy spawn.

    }
    private void spawnReef()
    {

    }

    private void spawnBoss()
    {

    }
}