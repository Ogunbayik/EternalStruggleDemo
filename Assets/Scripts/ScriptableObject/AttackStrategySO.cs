using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackStrategySO : ScriptableObject
{
    [Header("Attack Settings")]
    [SerializeField] private float _attackDuration;
    [SerializeField] private int _attackDamage;

    public abstract void ExecuteAttack(Transform user);

    public float AttackDuration => _attackDuration;
    public int AttackDamage => _attackDamage;
}
