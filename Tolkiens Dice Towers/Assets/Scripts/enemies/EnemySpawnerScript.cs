using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    [SerializeField] GameObject normalEnemy;
    [SerializeField] GameObject bigEnemy;

    [SerializeField] float spawnerInterval = 3.5f;

    [SerializeField] GameObject spawnPoint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnNormalEnemy(int count)
    {
        StartCoroutine(spawnEnemy(spawnerInterval, normalEnemy, count));
    }
    private IEnumerator spawnEnemy(float interval, GameObject enemy, int enemySpawnCount)
    {
        //if (enemySpawnCount == 0) { yield return; }
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, spawnPoint.transform);
        enemySpawnCount --;
        StartCoroutine(spawnEnemy(interval, enemy, enemySpawnCount));
    }
}
