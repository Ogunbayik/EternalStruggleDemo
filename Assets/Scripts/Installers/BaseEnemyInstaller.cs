using UnityEngine;
using Zenject;

public abstract class BaseEnemyInstaller : MonoInstaller
{
    [Header("Enemy Data SO")]
    [SerializeField] private EnemyDataSO _data;
    public override void InstallBindings()
    {
        Container.BindInstance(_data).AsSingle();
        var enemyComponent = GetComponent<EnemyBase>();

        if (enemyComponent is BossBase bossComponent)
            Container.BindInstance(bossComponent).AsSingle();

        Container.BindInterfacesAndSelfTo<EnemyBrain>().AsSingle().NonLazy();
      
        Container.Bind(typeof(BossBase), typeof(EnemyBase))
        .FromComponentOnRoot()
        .AsSingle();

        //States
        BindAttacks();
        BindStates();
    }

    protected abstract void BindStates();
    protected abstract void BindAttacks();
}