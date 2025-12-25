using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Player Data", menuName = "ScriptableObject/Player Data")]
public class PlayerDataSO : ScriptableObject
{
    [Header("Movement Settings")]
    [SerializeField] private float _movementSpeed;

    public float MovementSpeed => _movementSpeed;
}
