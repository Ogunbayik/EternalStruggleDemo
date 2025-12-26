using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    [SerializeField] private PlayerMovementController _playerPrefab;
    public override void InstallBindings()
    {
        Container.Bind<PlayerMovementController>().FromComponentInHierarchy().AsSingle();
    }
}