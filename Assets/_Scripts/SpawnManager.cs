using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Vector2 spawnRangeHorizontal;
    [SerializeField] private float spawnRate = 1;
    [SerializeField] private float spawnHeight;

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
