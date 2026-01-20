using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BossBase : EnemyBase
{
    public List<MeleeAttackStrategySO> _meleeAttackList;
    public List<RangeAttackStrategySO> _rangedAttackList;

    public Predicate<int> CanAttackAgain;

    [Inject]
    public void Construct(List<MeleeAttackStrategySO> meleeAttackList, List<RangeAttackStrategySO> rangedAttackList)
    {
        _meleeAttackList = meleeAttackList;
        _rangedAttackList = rangedAttackList;
    }

    public void DecideNextMove() => CanAttackAgain = (index) => index >= 6;
    public void GetRandomRoll() => UnityEngine.Random.Range(0, 11);
}
