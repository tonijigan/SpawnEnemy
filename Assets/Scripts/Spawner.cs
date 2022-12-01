using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private EnemyMovment _enemy;
    [SerializeField] private Transform _spawnPoints;
    [SerializeField] private float _numberOfSeconds;

    private Transform[] _points;

    private void Start()
    {
        CreatePoints();
        StartCoroutine(SpawnEnemy());
    }

    private void CreatePoints()
    {
        _points = new Transform[_spawnPoints.childCount];

        for (int i = 0; i < _spawnPoints.childCount; i++)
        {
            _points[i] = _spawnPoints.GetChild(i);
        }
    }

    private IEnumerator SpawnEnemy()
    {
        int minCountPoints = 0;
        var waitForSeconds = new WaitForSeconds(_numberOfSeconds);

        while (true)
        {
            yield return waitForSeconds;
            int currentPoint = Random.Range(minCountPoints, _points.Length);
            Instantiate(_enemy, _points[currentPoint]);
        }
    }
}
