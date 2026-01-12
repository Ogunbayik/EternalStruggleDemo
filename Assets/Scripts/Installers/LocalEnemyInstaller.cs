using UnityEngine;
using Zenject;

public class LocalEnemyInstaller : MonoInstaller
{
    [SerializeField] private PlayerView _player;
    [SerializeField] private EnemyDataSO _data;
    public override void InstallBindings()
    {
        Container.BindInstance(_data).AsSingle();
        Container.BindInstance(_player);

        Container.BindInterfacesAndSelfTo<EnemyBrain>().AsSingle().NonLazy();
        Container.Bind<EnemyBase>().FromComponentOnRoot().AsSingle();
        //States
        Container.Bind<IEnemyState>().To<EnemyChaseState>().AsCached();
        Container.Bind<IEnemyState>().To<EnemyAttackState>().AsCached();
    }
}