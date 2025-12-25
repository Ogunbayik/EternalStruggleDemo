using UnityEngine;
using Zenject;

public class DataInstaller : MonoInstaller
{
    [Header("Player Data")]
    [SerializeField] private PlayerDataSO _playerDataSO;
    public override void InstallBindings()
    {
        Container.BindInstance(_playerDataSO).AsSingle();

    }
}