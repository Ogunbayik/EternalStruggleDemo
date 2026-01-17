using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemyBase : MonoBehaviour
{
    protected EnemyDataSO _data;
    protected AttackStrategySO _attackStrategy;

    [Inject] 
    private DiContainer _container;

    [Inject]
    public void Construct(EnemyDataSO data, AttackStrategySO attackStrategy)
    {
        _data = data;
        _attackStrategy = attackStrategy;
        _container.Inject(_attackStrategy);
    }
    public void ChaseTarget(Transform target) => transform.position = Vector3.MoveTowards(transform.position, target.position, _data.MovementSpeed * Time.deltaTime);
    public EnemyDataSO Data => _data;
}
