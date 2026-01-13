using UnityEngine;
using Zenject;

public abstract class BaseEnemyInstaller : MonoInstaller
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
        BindStates();
        BindAttacks();
    }

    protected abstract void BindStates();
    protected abstract void BindAttacks();
}