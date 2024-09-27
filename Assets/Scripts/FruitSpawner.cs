using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    [SerializeField]
    private Transform[] spawnPoints;

    [SerializeField]
    private FruitPreset[] FruitPreset;


    [SerializeField]
    private GenericFruit FruitPrefab;

    [SerializeField]
    private float timeFirstWave = 0f;

    [SerializeField]
    private float timeBetweenWaves = 1f;

    private float timeToSpawn = float.PositiveInfinity;


    private void Start()
    {
        timeToSpawn = timeFirstWave;
    }

    void Update()
    {
        if(Time.time >= timeToSpawn)
        {
            SpawnObstacles();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }




    private void SpawnObstacles()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        int fruitIndex = Random.Range(0, FruitPreset.Length);
        int randomRotation = Random.Range(0,120);
  
        GenericFruit generatedGO = Instantiate<GenericFruit>(FruitPrefab, spawnPoints[randomIndex].position, Quaternion.Euler(new Vector3(0, 0, randomRotation)));
        generatedGO.Init(FruitPreset[fruitIndex]);
        
    }
}