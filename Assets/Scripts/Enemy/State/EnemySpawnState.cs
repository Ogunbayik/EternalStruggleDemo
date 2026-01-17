using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnState : IEnemyState
{
    private EnemyBrain _brain;
    private EnemyBase _enemy;

    private float _timer;

    public EnemySpawnState(EnemyBase enemy) => _enemy = enemy;
    public void Initialize(EnemyBrain brain) => _brain = brain;

    public void EnterState()
    {
        Debug.Log("Enemy is waiting for spawn animation!");
        _timer = _enemy.Data.SpawnTime;
    }
    public void ExitState()
    {

    }
    public void Tick()
    {
        _timer -= Time.deltaTime;
        
        if(_timer <= 0)
        {
            if (!_enemy.Data.IsBoss)
                _brain.SwitchState<EnemyChaseState>();
            else
                _brain.SwitchState<BossWaitingState>();
        }
    }
}
