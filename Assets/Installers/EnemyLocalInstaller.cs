using UnityEngine;
using Zenject;

public class EnemyLocalInstaller : MonoInstaller
{
    [Header("Enemy Data")]
    [SerializeField] private EnemyDataSO _enemyData;
    [Header("Enemy Abilities")]
    [SerializeField] private EnemyAbilitySO _enemyAbility;
    public override void InstallBindings()
    {
        Container.BindInstance(_enemyData).AsSingle();

        Container.Bind<EnemyBase>().FromComponentOnRoot().AsSingle();
        Container.Bind<EnemyStateMachine>().FromComponentOnRoot().AsSingle();
        Container.Bind<IAbility>().FromInstance(_enemyAbility).AsSingle();

        Container.Bind<EnemySpawnState>().AsTransient();
        Container.Bind<EnemyChaseState>().AsTransient();
    }
}