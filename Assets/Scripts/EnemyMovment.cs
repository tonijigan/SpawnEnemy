using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }
}
