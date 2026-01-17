using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonKing : BossBase
{
    [Header("Position Settings")]
    [SerializeField] private Transform _attackPosition;

    public Transform AttackPosition => _attackPosition;
    
}
