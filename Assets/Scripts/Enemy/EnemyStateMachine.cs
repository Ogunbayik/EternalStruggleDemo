using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemyStateMachine : MonoBehaviour
{
    //Enemy States
    private EnemySpawnState _spawnState;
    private EnemyChaseState _chaseState;

    private IEnemyState _currentState;

    [Inject]
    public void Construct(
        EnemySpawnState spawnState, 
        EnemyChaseState chaseState)
    {
        _spawnState = spawnState;
        _chaseState = chaseState;

        _spawnState.SetStateMachine(this);
        _chaseState.SetStateMachine(this);

        _currentState = _spawnState;
        _currentState.EnterState();
    }

    public EnemySpawnState SpawnState => _spawnState;
    public EnemyChaseState ChaseState => _chaseState;
    private void Update()
    {
        if (_currentState != null)
            _currentState.Tick();
    }
    public void SwitchState(IEnemyState newState)
    {
        if (_currentState == newState)
            return;

        if (_currentState != null)
            _currentState.ExitState();

        _currentState = newState;
        _currentState.EnterState();
    }

}
