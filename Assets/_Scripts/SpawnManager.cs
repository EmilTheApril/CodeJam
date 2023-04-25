using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] enemyPrefab;
    [SerializeField] private float spawnRate = 1;
    [SerializeField] private float spawnHeight;
    [SerializeField] float leftSideOfScreen;
    [SerializeField] float rightSideOfScreen;

    private void Awake()
    {
        leftSideOfScreen = Camera.main.transform.position.x - Camera.main.orthographicSize * Screen.width / Screen.height;
        rightSideOfScreen = Camera.main.transform.position.x + Camera.main.orthographicSize * Screen.width / Screen.height;
    }

    private void Start()
    {
        InvokeRepeating("SpawnObject", 0, spawnRate);
        spawnHeight = Camera.main.orthographicSize;
    }

    private Vector3 Spawnpos()
    {
        return new Vector3(Random.Range(leftSideOfScreen, rightSideOfScreen), spawnHeight, 0);
    }
    public void SpawnObject()
    {
        int rnd = Random.Range(0, enemyPrefab.Length);
        Instantiate(enemyPrefab[rnd], Spawnpos(), Quaternion.identity);
    }
}
