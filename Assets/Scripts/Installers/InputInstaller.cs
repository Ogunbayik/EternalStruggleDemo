using UnityEngine;
using Zenject;

public class InputInstaller : MonoInstaller
{
    [SerializeField] private PlayerDataSO _playerData;
    public override void InstallBindings()
    {
        Container.BindInstance(_playerData).AsSingle(); 
        Container.Bind<IInputService>().To<StandardKeyboard>().AsSingle();

        Container.Bind<PlayerModel>().AsSingle();
        Container.Bind<IPlayerView>().To<PlayerView>().FromComponentInHierarchy().AsSingle();
        Container.BindInterfacesAndSelfTo<PlayerPresenter>().AsSingle().NonLazy();
    }
}