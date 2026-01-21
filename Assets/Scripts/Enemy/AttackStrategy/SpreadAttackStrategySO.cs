using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "New Spread Attack", menuName = "SO/Range Strategy/Spread")]
public class SpreadAttackStrategySO : RangeAttackStrategySO
{
    [Inject]
    private Projectile.Factory _projectileFactory;

    [Header("Spread Settings")]
    [SerializeField] private float _angle;
    public override void ExecuteAttack(Transform user)
    {
        base.ExecuteAttack(user);
    }
    public override void CreateProjectile(Transform user)
    {
        for (int i = 0; i < _prefabCount; i++)
        {
            var spawnPosition = user.TransformPoint(_prefabOffset);

            var projectileAngle = _angle / _prefabCount;

            float step = Mathf.Ceil(i / 2f);
            float sign = (i % 2 == 0) ? 1 : -1;
            float finalDegree = step * sign * projectileAngle;

            var projectile = _projectileFactory.Create();
            projectile.transform.position = spawnPosition;
            projectile.transform.rotation = user.rotation * Quaternion.Euler(0f, finalDegree, 0f);
            
            projectile.Launch(_prefabSpeed);
        }
    }
}
