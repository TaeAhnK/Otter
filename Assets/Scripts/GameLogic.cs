using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameLogic : MonoBehaviour

{
    public GameObject otter;        // Otter Object
    public GameObject enemySpawner; // Enemy Spawner
    public GameObject reefSpawner;  // Reef Spawner

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
    bool babyOtter;                 // Dual Shot
    bool hyperWave;                 // Invinsible
    bool seaWirl;                   // Magnet
    bool slow;                      // Slow enemy and reef
    bool doubleScore;               // Gets double score


    private float slowDuration = 5f; // 슬로우 지속 시간 (초)
    private float originalEnemySpeed;
    private float originalReefSpeed;
    private float slowedEnemySpeed;
    private float slowedReefSpeed;


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

    }

    private void activateSeaWhirl()
    {

    }


    private void activateSlow()
    {
        originalEnemySpeed = getEnemySpeed();
        originalReefSpeed = getReefSpeed();

        slowedEnemySpeed = originalEnemySpeed * 0.5f;
        setEnemySpeed(slowedEnemySpeed);

        slowedReefSpeed = originalReefSpeed * 0.5f;
        setReefSpeed(slowedReefSpeed);

        StartCoroutine(ResetSpeedAfterDelay());


    }
    private IEnumerator ResetSpeedAfterDelay()
    {
        
            yield return new WaitForSeconds(slowDuration);

            // 원상 복구
            setEnemySpeed(originalEnemySpeed);
            setReefSpeed(originalReefSpeed);
        
    }
    private void activateDoubleScore()
    {


    }
    
}