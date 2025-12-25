using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemySpawnState : IEnemyState
{
    private readonly EnemyStateMachine _stateMachine;

    private float _testTimer = 5f;

    public EnemySpawnState(EnemyStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void EnterState()
    {
        Debug.Log("Enemy is in Spawn State!");
    }

    public void ExitState()
    {

    }

    public void Tick()
    {
        _testTimer -= Time.deltaTime;

        if(_testTimer <= 0)
        {
            _stateMachine.SwitchState(_stateMachine.ChaseState);
            _testTimer = 5f;
        }
    }

}
