using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemyBase : MonoBehaviour
{
    protected EnemyDataSO _data;

    [Inject] 
    protected DiContainer _container;

    protected AttackStrategySO _currentAttackStrategy;

    private bool _isFlying;

    [Inject]
    public void ConstructBase(EnemyDataSO data) => _data = data;
    public void ChaseTarget(Transform target) => transform.position = Vector3.MoveTowards(transform.position, target.position, _data.MovementSpeed * Time.deltaTime);
    public EnemyDataSO Data => _data;
    public void SetAttackStrategy(AttackStrategySO attackStrategy) => _currentAttackStrategy = attackStrategy;
    public void SetFlyStatus(bool isActive) => _isFlying = isActive; 
    public bool IsFlying => _isFlying;
    public AttackStrategySO CurrentAttackStrategy => _currentAttackStrategy;
}
