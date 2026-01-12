using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackState : IEnemyState
{
    private PlayerView _player;
    private EnemyBase _enemy;
    private EnemyBrain _brain;

    private float _attackTimer;

    public EnemyAttackState(EnemyBase enemy, PlayerView player)
    {
        _enemy = enemy;
        _player = player;
    }
    public void Initialize(EnemyBrain brain) => _brain = brain;
    public void EnterState()
    {
        _enemy.transform.LookAt(_player.transform);
        ExecuteAttack();
    }
    public void ExitState()
    {
        Debug.Log("Exit Attack State");
    }
    public void Tick()
    {
        _attackTimer -= Time.deltaTime;

        if (_attackTimer <= 0)
            DecideNextMove();
    }
    private void ExecuteAttack()
    {
        Debug.Log("Playing Attack Animation");
        _attackTimer = _enemy.Data.AttackDuration;
    }
    private void DecideNextMove()
    {
        var distanceToPlayer = Vector3.Distance(_enemy.transform.position, _player.transform.position);

        if (distanceToPlayer > _enemy.Data.AttackDistance)
            _brain.SwitchState<EnemyChaseState>();

        //Player still in attack distance
        ExecuteAttack();
    }
}
