using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class RangeBase : EnemyBase
{
    protected List<AttackStrategySO> _rangeStrategyList;

    [Inject]
    public void Construct(List<AttackStrategySO> rangeStrategyList)
    {
        _rangeStrategyList = rangeStrategyList;

        foreach (var strategy in _rangeStrategyList)
        {
            _container.Inject(strategy);

            _currentAttackStrategy = strategy;
        }
    }
}
