using UnityEngine;
using Zenject;

public class EnemyInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //EnemyStates
        Container.Bind<EnemySpawnState>().AsSingle();
        Container.Bind<EnemyChaseState>().AsSingle();

        Container.Bind<EnemyStateMachine>().FromComponentInHierarchy().AsSingle();
    }
}