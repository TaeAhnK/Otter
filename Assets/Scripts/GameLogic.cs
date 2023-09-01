using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameLogic : MonoBehaviour

{
    public GameObject otter;        // Otter Object
    public GameObject enemySpawner; // Enemy Spawner
    public GameObject reefSpawner;  // Reef Spawner

    private int score = 0;              // Score

    // Otter Info
    private int otterLife = 100;          // Otter Life
    private int otterEXP = 0;             // Otter Exp
    public int otterDamage = 50;         // Otter Damage

    // Speed Info
    private float enemySpeed = 5f;          // Enemy Move Speed
    private float reefSpeed = 5f;           // Rate Move Speed
    private float itemSpeed = 5f;

    // Item Activation
    public bool babyOtter;                 // Dual Shot
    public bool hyperWave;                 // Invinsible
    public bool seaWirl;                   // Magnet
    public bool slow;                      // Slow enemy and reef
    public bool doubleScore;               // Gets double score

    // timer
    private float timer = 0;

    // Reef, Enemy 생성 좌표
    private float[] spawnPosX = { -3f, -1.5f, 0f, 1.5f, 3f };

    // Reef 변수
    public float SpawnRate = 2;             // 동시다발 시 암초가 나오는 주기 
    private float RealTime = 0;             // 실제 시간
    private float intervaltimer = 0;        // 암초 나오는 주기를 확인하기 위한 타이머
    private int count = 0;                  // 동시다발적으로 나올 때의 암초 개수
    private bool flag = false;
    private bool flag2 = false;

    // Enemy 변수
    private float minSpawnDelay = 10f; // 적 생성 간격의 최소값
    private float maxSpawnDelay = 15f;// 적 생성 간격의 최대값
    private float nextSpawnTime;

    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;
        
        // Reef
        RealTime += Time.deltaTime;
        intervaltimer += Time.deltaTime;

        // Enemy
        setReefIntervalSpeed();
        if (Time.time >= nextSpawnTime)
        {
            enemySpawner.GetComponent<EnemySpawner>().StartEnemyRoutine(); // Start spawning enemies using EnemySpawner.
            SetNextSpawnTime();
        }
    }

    // Score Method
    public int getScore()
    {
        return score;
    }

    public void addScore(int add)
    {
        score += add;
    }
    public int getOtterLife()
    {
        return otterLife;
    }

    // Otter Info Method
    public int getOtterEXP()
    {
        return otterEXP;
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

    // Spawner Method
    public float[] getSpawnPosX()
    {
        return spawnPosX;
    }

    // Reef Method    
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

    private void spawnReef()
    {

    }
    private void spawnReef()
    {

    }

    // Enemy Method
    public float getEnemySpeed()
    {
        return enemySpeed;
    }

    public void setEnemySpeed(float speed)
    {
        enemySpeed = speed;
    }


    private void spawnBoss()
    {

    }

    private void activateBabyOtter()
    {

    }

    // Item Method
    public float getItemSpeed()
    {
        return itemSpeed;
    }
    private void spawnBoss()
    {
    
    }

    private void activateHyperWave()
    {
        
    }

    private void activateSeaWhirl()
    {
        
    }

    private void activateSlow()
    {
    
    }

    private void activateDoubleScore()
    {
        
    }
}