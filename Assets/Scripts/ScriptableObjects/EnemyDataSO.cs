using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Data", menuName = "ScriptableObject/Enemy Data")]
public class EnemyDataSO : ScriptableObject
{
    [Header("Identity Settings")]
    [SerializeField] private string _name;
    [Header("Move Settings")]
    [SerializeField] private float _movementSpeed;
    [SerializeField] private GameObject _projectilePrefab;

    public string Name => _name;
    public float MovementSpeed => _movementSpeed;
    public GameObject ProjectilePrefab => _projectilePrefab;
    

}
