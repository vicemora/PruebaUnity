using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    private GameObject enemySpawned;
    
    float xPos;
    Vector3 posXY;
    float nextSpawnTime;
    public float spawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        spawnDelay = 1f;
        nextSpawnTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextSpawnTime){
            nextSpawnTime += spawnDelay;
            xPos = Random.Range(-11f, 11f);
            posXY = new Vector3(xPos, 5.65f, 0f);
            enemySpawned = Instantiate(enemy, posXY, Quaternion.identity);
        }
    }

    
}
