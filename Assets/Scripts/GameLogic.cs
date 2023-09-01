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
    private int otterDamage = 50;         // Otter Damage

    // Enemy Info
    private int enemyLife = 100;
    private float enemySpeed = 5f;       // Enemy Move Speed
    private float reefSpeed = 5;        // Rate Move Speed

    // Item Activation
    bool babyOtter;                 // Dual Shot
    bool hyperWave;                 // Invinsible
    bool seaWirl;                   // Magnet
    bool slow;                      // Slow enemy and reef
    bool doubleScore;               // Gets double score

    void Start()
    {

    }

    void Update()
    {

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

    public int getEnemyLife()
    {
        return enemyLife;
    }

    public float getEnemySpeed()
    {
        return enemySpeed;
    }

    public void getEnemyDamage()
    {
        enemyLife -= otterDamage;
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

    private void spawnReef()
    {

    }

    private void spawnBoss()
    {

    }

    private void activateBabyOtter()
    {

    }

    private void activateHyperWave()
    {
        float timer=0.0f;                  // 타이머 설정
        timer+=Time.deltaTime;
        if (timer>0.1f)
            {
                reefSpeed=5;
                enemySpeed=5f;
                otterLife=100;
                
            }

        else
        {
            reefSpeed=10;
            enemySpeed=10f;
            otterLife=1000000;
        }

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