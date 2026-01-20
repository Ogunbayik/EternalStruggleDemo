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

        if(_attackTimer <= 0)
        {
            if (!_enemy.Data.IsBoss)
                _brain.SwitchState<EnemyChaseState>();
            else
                _brain.SwitchState<BossDecideState>();
        }
    }
    private void ExecuteAttack()
    {
        _enemy.CurrentAttackStrategy.ExecuteAttack(_enemy.transform);
        _attackTimer = _enemy.Data.AttackDuration;
        Debug.Log("Playing Attack Animation");
    }
}
