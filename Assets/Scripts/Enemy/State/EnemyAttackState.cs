using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackState : IEnemyState
{
    private EnemyBase _enemy;
    private BossBase _boss;
    private EnemyBrain _brain;

    private float _attackTimer;

    public EnemyAttackState(EnemyBase enemy)
    {
        _enemy = enemy;
        _boss = enemy as BossBase;
    }
    public void Initialize(EnemyBrain brain) => _brain = brain;
    public void EnterState() => ExecuteAttack();
    
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
            {
                _boss.IncreaseFlyAttackCount();
                _brain.SwitchState<BossDecideState>();
            }
        }
    }
    private void ExecuteAttack()
    {
        _enemy.transform.LookAt(_enemy.Player.transform);
        _enemy.CurrentAttackStrategy.ExecuteAttack(_enemy.transform);
        _attackTimer = _enemy.Data.AttackDuration;
        Debug.Log("Playing Attack Animation");
    }
}
