using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonKingInstaller : BaseEnemyInstaller
{
    [Header("Attack Settings")]
    //[SerializeField] private AttackStrategySO _meleeAttack;
    [SerializeField] private AttackStrategySO _rangeAttack;
    protected override void BindAttacks()
    {
        //Container.Bind<AttackStrategySO>().FromInstance(_meleeAttack).AsSingle().NonLazy();
        Container.Bind<AttackStrategySO>().FromInstance(_rangeAttack).AsSingle().NonLazy();
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
