using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemyInstaller : BaseEnemyInstaller
{
    [Header("Attack Strategy Settings")]
    [SerializeField] private MeleeAttackStrategySO _meleeAttack;
    protected override void BindAttacks()
    {
        Container.Bind<MeleeAttackStrategySO>().FromInstance(_meleeAttack).AsSingle().NonLazy();
    }

    protected override void BindStates()
    {
        Container.Bind<IEnemyState>().To<EnemySpawnState>().AsSingle();
        Container.Bind<IEnemyState>().To<EnemyChaseState>().AsSingle();
        Container.Bind<IEnemyState>().To<EnemyAttackState>().AsSingle();
    }
}
