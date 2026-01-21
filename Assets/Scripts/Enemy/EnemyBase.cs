using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemyBase : MonoBehaviour 
{
    protected EnemyDataSO _data;
    protected PlayerView _player;

    [Inject] 
    protected DiContainer _container;

    protected AttackStrategySO _currentAttackStrategy;

    [Inject]
    public void ConstructBase(EnemyDataSO data, PlayerView player)
    {
        _data = data;
        _player = player;
    }
    public void ChaseTarget(Transform target) => transform.position = Vector3.MoveTowards(transform.position, target.position, _data.MovementSpeed * Time.deltaTime);
    public EnemyDataSO Data => _data;
    public void SetAttackStrategy(AttackStrategySO attackStrategy)
    {
        _currentAttackStrategy = attackStrategy;

        _container.Inject(_currentAttackStrategy);
    }
    public AttackStrategySO CurrentAttackStrategy => _currentAttackStrategy;
    public PlayerView Player => _player;
    
}