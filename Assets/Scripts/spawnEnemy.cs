using UnityEngine;
using System.Collections;

public class spawnEnemy : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    bool isSpawning = false;
    public float minTime;
    public float maxTime;
    public GameObject[] enemies;  // Array of enemy prefabs.

    IEnumerator SpawnObject(int index, float seconds)
    {
        Debug.Log("Waiting for " + seconds + " seconds");

       yield return new WaitForSeconds(seconds);
       Instantiate(enemy, new Vector2(Random.Range(-1, 1), Random.Range(-1, 1)),  Quaternion.identity);
 
        isSpawning = false;
    }

    void Update()
    {
       enemy = GameObject.Find("Enemy");
       player = GameObject.Find("Player");
        
        //We only want to spawn one at a time, so make sure we're not already making that call
        if (!isSpawning)
        {
           isSpawning = true; //Yep, we're going to spawn
           int enemyIndex = Random.Range(0, enemies.Length);
            StartCoroutine(SpawnObject(enemyIndex, Random.Range(minTime, maxTime)));
        
               
        //We've spawned, so now we could start another spawn    
        }
    
 
    }
}
