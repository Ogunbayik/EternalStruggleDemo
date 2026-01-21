using System.Collections.Generic;
using Zenject;

public class BossBase : EnemyBase
{
    public List<MeleeAttackStrategySO> _meleeAttackList;
    public List<RangeAttackStrategySO> _rangedAttackList;

    private int _flyAttackCount;

    private bool _isFlying;

    [Inject]
    public void Construct(List<MeleeAttackStrategySO> meleeAttackList, List<RangeAttackStrategySO> rangedAttackList)
    {
        _meleeAttackList = meleeAttackList;
        _rangedAttackList = rangedAttackList;
    }
    public void SetFlyingStatus(bool isActive) => _isFlying = isActive;
    public bool IsFlying => _isFlying;
    public void IncreaseFlyAttackCount() => _flyAttackCount++;
    public void ResetFlyAttackCount() => _flyAttackCount = 0;
    public int FlyAttackCount => _flyAttackCount;
    public AttackStrategySO GetRandomRangeStrategy()
    {
        var randomIndex = UnityEngine.Random.Range(0, _rangedAttackList.Count);
        var randomRangeStrategy = _rangedAttackList[randomIndex];
        return randomRangeStrategy;
    }

}
