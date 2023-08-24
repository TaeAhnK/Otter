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

    void Start()
    {
        otterLife = 3;
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

    private void spawnReef()
    {

    }

    private void spawnBoss()
    {

    }
}