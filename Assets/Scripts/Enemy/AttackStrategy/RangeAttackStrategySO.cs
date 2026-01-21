using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RangeAttackStrategySO : AttackStrategySO
{
    [Header("Attack Settings")]
    [SerializeField] protected GameObject _prefab;
    [SerializeField] protected int _prefabCount;
    [SerializeField] protected float _prefabSpeed;
    [SerializeField] protected Vector3 _prefabOffset;

    public override void ExecuteAttack(Transform user)
    {
        Debug.Log($"{user.name} is using Fireball");
        CreateProjectile(user);
    }

    public abstract void CreateProjectile(Transform user);
}
