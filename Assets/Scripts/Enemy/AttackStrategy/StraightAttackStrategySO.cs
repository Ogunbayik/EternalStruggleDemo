using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "New Spread Attack", menuName = "SO/Range Strategy/Straight")]
public class StraightAttackStrategySO : RangeAttackStrategySO
{
    [Inject]
    private Projectile.Factory _projectileFactory;

    public override void CreateProjectile(Transform user)
    {
        var projetile = _projectileFactory.Create();
        projetile.transform.position = user.transform.position;
        projetile.transform.rotation = user.transform.rotation;
        projetile.Launch(_prefabSpeed);
    }

}
