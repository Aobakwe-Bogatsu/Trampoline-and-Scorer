using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject[] prefabToSpawn; //Array of objects for prefabs we want to spawn
    public float spawnInterval = 5f; //The spawn interval - the prefabs will spawn once every 5 seconds

    public Scorer theScorer;

    // Start is called before the first frame update
    void Start() //called once
    {
        InvokeRepeating("SpawnPrefab", 0f, spawnInterval); //call the method 'SpawnPrefab' method after 0 secs (immediately), repeat every 5 secs
    }

    void SpawnPrefab() //spawns the prefabs
    {
        Vector3 spawnPos = new Vector3(Random.Range(-5, 10), 20, Random.Range(-5,5)); //
        GameObject newObj = Instantiate(prefabToSpawn[Random.Range(0,3)], spawnPos, Quaternion.identity);
        newObj.GetComponent<AI>().myScorer = theScorer;
        
    }

}
