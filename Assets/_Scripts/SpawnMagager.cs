using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMagager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Vector2 spawnRangeHorizontal;
    public float spawnRate = 1;
    float spawnHeight;

    private void Start()
    {
        InvokeRepeating("SpawnObject", 0, spawnRate);
    }

    private Vector3 Spawnpos()
    {
        return new Vector3(Random.Range(spawnRangeHorizontal.x,spawnRangeHorizontal.y),spawnHeight,0);
    }
    public void SpawnObject()
    {
        Instantiate(enemyPrefab,Spawnpos(), Quaternion.identity);
    }
}
