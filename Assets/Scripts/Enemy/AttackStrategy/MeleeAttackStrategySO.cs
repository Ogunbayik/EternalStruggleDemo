using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Attack Strategy", menuName = "SO/Attack Strategy/Melee")]
public class MeleeAttackStrategySO : AttackStrategySO
{
    public override void ExecuteAttack(Transform user)
    {
        Debug.Log($"{user.name} is using melee attack!");
    }
}
