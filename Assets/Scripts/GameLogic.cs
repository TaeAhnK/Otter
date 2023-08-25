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

    //timer
    private float timer = 0;

    //Reef용 변수
    public float SpawnRate = 2;
    //동시다발 시 암초가 나오는 주기 
    private float RealTime = 0;
    //실제 시간
    private float intervaltimer = 0;
    //암초 나오는 주기를 확인하기 위한 타이머
    private int count = 0;
    //동시다발적으로 나올 때의 암초 개수
    private bool flag = false;
    private bool flag2 = false;
    //Reef용 변수 여기까지

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
        timer += Time.deltaTime;
        //Reef
        RealTime += Time.deltaTime;
        intervaltimer += Time.deltaTime;
        
        setReefIntervalSpeed();
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
        reefSpeed = 5;
        return reefSpeed;
        
    }

    public void setReefSpeed(float speed)
    {
        reefSpeed = speed;
    }

    public float SpeedControl()
    {
        //속도조절
        //시간이 지날수록 속도 증가
        reefSpeed = getReefSpeed();
        
        if (timer == 5 || timer > 5)
        {
            reefSpeed += 1;  // 속도 증가
            Debug.Log("속도 1 증가");
            timer = 0;  // 시간 초기화
            Debug.Log(reefSpeed);
        }

        //setReefSpeed(reefSpeed);
        return reefSpeed;
        
    }

    public void setReefIntervalSpeed()
    {
        if (flag == true && RealTime > 10)
        //실제 시간이 10초가 됐을 때 동시다발적
        {

            if (flag2 == false && intervaltimer > SpawnRate)
            //SpawnRate마다 암초가 나오도록
            {
                //Debug.Log("동시다발");
                reefSpawner.GetComponent<ReefSpawner>().SpawnReef();
                count++;
                //Debug.Log("더하기");
                intervaltimer = 0;

                if (count > 5)
                //나온 암초가 5개가 돼었을 때
                {
                    count = 0;
                    //암초개수 초기화
                    RealTime = 0;
                    //실제시간 초기화
                    flag = false;
                    flag2 = true;
                }
                flag2 = false;
            }

        }

        if (flag == false && RealTime > 5)
        //실제 시간이 5초가 됐을 때
        {
            reefSpawner.GetComponent<ReefSpawner>().SpawnReef();
            flag = true;
            //flag를 true로 변경시켜 맨 위의 if문으로 이동
            RealTime += Time.deltaTime;
            //Debug.Log("한 번");

        }
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