using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MeleeBase : EnemyBase
{
    protected List<MeleeAttackStrategySO> _meleeStrategyList;

    [Inject]
    public void Construct(List<MeleeAttackStrategySO> meleeStrategyList)
    {
        _meleeStrategyList = meleeStrategyList;

        foreach(AttackStrategySO strategy in meleeStrategyList)
        {
            _container.Inject(strategy);
            //Only for one attack
            _currentAttackStrategy = strategy;
        }
    }
}
