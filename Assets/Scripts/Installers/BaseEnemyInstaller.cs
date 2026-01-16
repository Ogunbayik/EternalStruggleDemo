using UnityEngine;
using Zenject;

public abstract class BaseEnemyInstaller : MonoInstaller
{
    [SerializeField] private EnemyDataSO _data;
    public override void InstallBindings()
    {
        Container.BindInstance(_data).AsSingle();

        Container.BindInterfacesAndSelfTo<EnemyBrain>().AsSingle().NonLazy();
        Container.Bind<EnemyBase>().FromComponentOnRoot().AsSingle();

        //States
        BindAttacks();
        BindStates();
    }

    protected abstract void BindStates();
    protected abstract void BindAttacks();
}