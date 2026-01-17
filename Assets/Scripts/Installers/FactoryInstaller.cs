using UnityEngine;
using Zenject;

public class FactoryInstaller : MonoInstaller
{
    [SerializeField] private GameObject _testProjectilePrefab;
    public override void InstallBindings()
    {
        Container.BindFactory<Projectile, Projectile.Factory>()
            .FromComponentInNewPrefab(_testProjectilePrefab)
            .AsSingle();
    }
}