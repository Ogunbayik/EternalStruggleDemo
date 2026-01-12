using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyChaseState : IEnemyState
{
    private EnemyBase _enemy;
    private EnemyBrain _brain;
    private PlayerView _player;

    public EnemyChaseState(EnemyBase enemy, PlayerView player)
    {
        _enemy = enemy;
        _player = player;
    }
    public void Initialize(EnemyBrain brain) => _brain = brain;
    public void EnterState()
    {
        Debug.Log("Activate realising animation");
    }
    public void ExitState()
    {

    }
    public void Tick()
    {
        var distanceToPlayer = Vector3.Distance(_enemy.transform.position, _player.transform.position);

        if (distanceToPlayer < _enemy.Data.AttackDistance)
            _brain.SwitchState<EnemyAttackState>();

        _enemy.ChaseTarget(_player.transform);
        HandleMovement();
    }
    private void HandleMovement()
    {
        _enemy.transform.position = Vector3.MoveTowards(_enemy.transform.position, _player.transform.position, _enemy.Data.MovementSpeed * Time.deltaTime);
    }

}
