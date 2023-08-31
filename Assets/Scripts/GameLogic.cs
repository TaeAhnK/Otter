using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameLogic : MonoBehaviour

{
    public GameObject otter;        // Otter Object
    public GameObject enemySpawner; // Enemy Spawner
    public GameObject reefSpawner;  // Reef Spawner
    public GameObject ShellShooterBabyOtter;

    public int score = 0;              // Score

    // Otter Info
    private int otterLife = 100;          // Otter Life
    private int otterEXP = 0;             // Otter Exp
    public int otterDamage = 50;         // Otter Damage

    // Enemy Info
    public int enemyLife = 100;
    private float enemySpeed;       // Enemy Move Speed
    private float reefSpeed;        // Rate Move Speed

    // Item Activation
    bool babyOtter;         // Dual Shot
    bool hyperWave;                 // Invinsible
    bool seaWirl;                   // Magnet
    bool slow;                      // Slow enemy and reef
    bool doubleScore;               // Gets double score

    private float timer = 0;
    private float babyotterTime = 4;
    


    void Start()
    {
        
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log(timer);
        activateBabyOtter();

        
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
        //쉘슈터 활성화
        
        if (timer<babyotterTime)
        {
            ShellShooterBabyOtter.SetActive(true);
        }
        else
        {
            ShellShooterBabyOtter.SetActive(false);
            Debug.Log("false Test");
            Debug.Log(timer);
            timer = 0;
        }
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