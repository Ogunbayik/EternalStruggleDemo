using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonKingInstaller : BaseEnemyInstaller
{
    [Header("Attack Strategy Settings")]
    [SerializeField] private MeleeAttackStrategySO _meleeAttack;
    [SerializeField] private RangeAttackStrategySO _rangeAttack;
    [SerializeField] private RangeAttackStrategySO _secondRangeAttack;
    protected override void BindAttacks()
    {
        Container.Bind<MeleeAttackStrategySO>().FromInstance(_meleeAttack).AsCached().NonLazy();
        Container.Bind<RangeAttackStrategySO>().FromInstance(_rangeAttack).AsCached().NonLazy();
        Container.Bind<RangeAttackStrategySO>().FromInstance(_secondRangeAttack).AsCached().NonLazy();
    }

    protected override void BindStates()
    {
        //General States
        Container.Bind<IEnemyState>().To<EnemySpawnState>().AsSingle();
        Container.Bind<IEnemyState>().To<EnemyChaseState>().AsSingle();
        Container.Bind<IEnemyState>().To<EnemyAttackState>().AsSingle();
        //Special States
        Container.Bind<IEnemyState>().To<BossWaitingState>().AsSingle();
        Container.Bind<IEnemyState>().To<BossFlyState>().AsSingle();
        Container.Bind<IEnemyState>().To<BossDecideState>().AsSingle();
        Container.Bind<IEnemyState>().To<BossLandState>().AsSingle();
    }
}
