using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonKingInstaller : BaseEnemyInstaller
{
    [Header("Attack Strategy Settings")]
    [SerializeField] private MeleeAttackStrategySO _meleeAttack;
    [SerializeField] private RangeAttackStrategySO _rangeAttack;
    protected override void BindAttacks()
    {
        Container.Bind<MeleeAttackStrategySO>().FromInstance(_meleeAttack).AsCached().NonLazy();
        Container.Bind<RangeAttackStrategySO>().FromInstance(_rangeAttack).AsCached().NonLazy();
    }

    protected override void BindStates()
    {
        Container.Bind<IEnemyState>().To<EnemySpawnState>().AsSingle();
        Container.Bind<IEnemyState>().To<EnemyChaseState>().AsSingle();
        Container.Bind<IEnemyState>().To<EnemyAttackState>().AsSingle();
        Container.Bind<IEnemyState>().To<BossWaitingState>().AsSingle();
        Container.Bind<IEnemyState>().To<BossFlyState>().AsSingle();
    }
}
