using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private List<Transform> _spawnerObjects;
    [Space]
    [SerializeField] private float _spawnDelayTime;

    private void Start()
    {
        StartCoroutine(EnemySpawnCoroutine());
    }

    private IEnumerator EnemySpawnCoroutine()
    {
        yield return new WaitForSeconds(_spawnDelayTime);

        GameObject _enemy = Instantiate(_enemyPrefab, GetRandomSpawnerRect().position, Quaternion.identity, transform);
        _enemy.transform.SetParent(UnitsContent.Instance.transform);
        StartCoroutine(EnemySpawnCoroutine());
    }

    private Transform GetRandomSpawnerRect()
    {
        return _spawnerObjects[Random.Range(0, _spawnerObjects.Count)];
    }
}
