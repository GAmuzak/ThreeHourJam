using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField][Range(1,5)] private float spawnTimer;
    [SerializeField] private float xBound;
    [SerializeField] private float zBound;
    [SerializeField] private GameObject enemy;
    [SerializeField] private Transform enemyContainer;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(Random.Range(0,spawnTimer));
        Vector3 SpawnPoint = new Vector3(Random.Range(xBound, -xBound), 0, Random.Range(zBound, -zBound));
        Instantiate(enemy, SpawnPoint, Quaternion.identity, enemyContainer);
    }
}
