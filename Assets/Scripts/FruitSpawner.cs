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

    private bool isGameOver = false;
    private void Start()
    {
        timeToSpawn = timeFirstWave;
    }

    void Update()
    {
       // Check if the game is paused or over before spawning fruits
        if (Time.timeScale == 0 || isGameOver)
        {
            return;  // Do not spawn when the game is paused or over
        }

        // Continue spawning if the game is running
        if (Time.time >= timeToSpawn)
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