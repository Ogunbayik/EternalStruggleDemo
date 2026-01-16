using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Attack Strategy", menuName = "SO/Attack Strategy/Range")]
public class RangeAttackStrategySO : AttackStrategySO
{
    [Header("Attack Settings")]
    [SerializeField] private GameObject _prefab;
    [SerializeField] private int _prefabCount;
    [SerializeField] private float _prefabSpeed;

    public override void ExecuteAttack(Transform user)
    {
        Debug.Log($"{user.name} is using Fireball");
    }

}
