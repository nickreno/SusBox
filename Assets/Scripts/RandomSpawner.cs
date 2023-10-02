using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;

    public static bool killedEnemy = false;

    // Update is called once per frame
    void Update()
    {
        if (killedEnemy == true)    //|| Input.GetKeyDown(KeyCode.E) **testing purposes**
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-30, 30), 5, Random.Range(30,30));        //Random.Range(-60, 60), 5, Random.Range(0,60)
            Instantiate(EnemyPrefab, randomSpawnPosition, Quaternion.identity);
            randomSpawnPosition = new Vector3(Random.Range(-60, 60), 5, Random.Range(0, 60));
            Instantiate(EnemyPrefab, randomSpawnPosition, Quaternion.identity); //spawns 2 enemies for each 1 that was killed
            killedEnemy = false;
        }
        
    }
}
