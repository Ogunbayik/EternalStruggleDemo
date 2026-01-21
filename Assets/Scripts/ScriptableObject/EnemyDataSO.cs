using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Data", menuName = "SO/Enemy/Enemy Data")]
public class EnemyDataSO : ScriptableObject
{
    [Header("ID Settings")]
    [SerializeField] private string _enemyName;
    [SerializeField] private bool _isBoss;
    [Header("Spawn Settings")]
    [SerializeField] private float _spawnTime;
    [Header("Movement Settings")]
    [SerializeField] private float _movementSpeed;
    [Header("Attack Settings")]
    [SerializeField] private float _attackDistance;
    [SerializeField] private float _attackDuration;

    public string Name => _enemyName;
    public bool IsBoss => _isBoss;
    public float SpawnTime => _spawnTime;
    public float MovementSpeed => _movementSpeed;
    public float AttackDistance => _attackDistance;
    public float AttackDuration => _attackDuration;
}
