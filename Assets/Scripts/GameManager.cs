using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemyOnePrefab;
    public GameObject enemyTwoPrefab;

    void Start()
    {
        InvokeRepeating("CreateEnemyOne", 1f, 2f);     // Enemy 1 every 2 seconds
        InvokeRepeating("CreateEnemyTwo", 5f, 3.5f);   // Enemy 2 every 3.5 seconds
    }

    void CreateEnemyOne()
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0f), Quaternion.identity);
    }

    void CreateEnemyTwo()
    {
        Instantiate(enemyTwoPrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0f), Quaternion.identity);
    }
}