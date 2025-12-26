using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemyChaseState : IEnemyState
{
    private readonly EnemyBase _enemy;
    private readonly PlayerMovementController _player;
    private readonly IAbility _ability;

    private EnemyStateMachine _stateMachine;

    [Inject]
    public EnemyChaseState(EnemyBase enemy, PlayerMovementController player, IAbility ability)
    {
        _enemy = enemy;
        _player = player;
        _ability = ability;
    }
    public void SetStateMachine(EnemyStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void EnterState()
    {
        Debug.Log("Enemy Enter Chase State");
    }

    public void ExitState()
    {

    }

    public void Tick()
    {
        ChaseTarget();

        if (Input.GetKeyDown(KeyCode.Space))
            _ability.OnEffectRealized(_enemy, _player.transform);
    }
    private void ChaseTarget()
    {
        _enemy.transform.position = Vector3.MoveTowards(_enemy.transform.position, _player.transform.position, 1f * Time.deltaTime);
    }
}
