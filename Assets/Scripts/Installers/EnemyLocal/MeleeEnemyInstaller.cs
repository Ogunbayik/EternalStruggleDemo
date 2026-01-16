using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemyInstaller : BaseEnemyInstaller
{
    protected override void BindAttacks()
    {

    }

    protected override void BindStates()
    {
        Container.Bind<IEnemyState>().To<EnemyChaseState>().AsCached();
        Container.Bind<IEnemyState>().To<EnemyAttackState>().AsCached();
    }
}
