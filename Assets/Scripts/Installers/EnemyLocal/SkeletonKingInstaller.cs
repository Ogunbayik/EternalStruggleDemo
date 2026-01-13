using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonKingInstaller : BaseEnemyInstaller
{
    protected override void BindAttacks()
    {
        Container.Bind<IAttackStrategy>().To<MeleeAttack>().AsCached();
    }

    protected override void BindStates()
    {
        Container.Bind<IEnemyState>().To<EnemyChaseState>().AsCached();
        Container.Bind<IEnemyState>().To<EnemyAttackState>().AsCached();
    }
}
