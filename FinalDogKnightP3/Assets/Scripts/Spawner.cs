using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] spawners;
    public GameObject[] enemy ;

    public int waveNumber = 0;
    public int enemySpawnAmount = 0;
    public int enemiesKilled = 0;

    private void Start()
    {
        spawners = new GameObject[2];
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        
        for (int i = 0; i < enemy.Length; i++)
        {
            enemy[i] = transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < spawners.Length; i++)
        {
            spawners[i] = transform.GetChild(i).gameObject;
        }

        StartWave();
    }

    private void SpawnEnemy()
    {

        int spawnerID = Random.Range(0, spawners.Length);
        int enemyID = Random.Range(0, enemy.Length);
        Instantiate(enemy[enemyID], spawners[spawnerID].transform.position, spawners[spawnerID].transform.rotation);
    }

    private void StartWave()
    {
        waveNumber = 1;
        enemySpawnAmount = 2;
        enemiesKilled = 0;

        for(int i = 0; i < enemySpawnAmount; i++)
        {
            SpawnEnemy();
        }
    }

    public void NextWave()
    {
        waveNumber++;
        enemySpawnAmount += 2;
        enemiesKilled = 0;

        for (int i = 0; i < enemySpawnAmount; i++)
        {
            SpawnEnemy();
        }
    }
}
