using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Vector2 spawnRangeHorizontal;
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
        Debug.Log(leftSideOfScreen + " " + rightSideOfScreen);
        spawnHeight = Camera.main.orthographicSize;// * 2;
    }

    private Vector3 Spawnpos()
    {
        return new Vector3(Random.Range(leftSideOfScreen,rightSideOfScreen),spawnHeight,0);
    }
    public void SpawnObject()
    {
        Instantiate(enemyPrefab,Spawnpos(), Quaternion.identity);
    }
}
