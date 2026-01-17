using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemyBrain : ITickable, IInitializable
{
    private IEnemyState _currentState;

    private List<IEnemyState> _allStates;
    private Dictionary<Type, IEnemyState> _stateMap = new Dictionary<Type, IEnemyState>();

    public EnemyBrain(List<IEnemyState> allStates) => _allStates = allStates; 

    public void Initialize()
    {
        foreach (var state in _allStates)
        {
            state.Initialize(this);
            _stateMap[state.GetType()] = state;
        }

        SwitchState<EnemySpawnState>();
    }
    public void SwitchState<T>() where T : IEnemyState
    {
        var newState = _stateMap[typeof(T)];
        SwitchState(newState);
    }
    public void SwitchState(IEnemyState newState)
    {
        if (_currentState == newState)
            return;

        _currentState?.ExitState();
        _currentState = newState;
        _currentState.EnterState();
    }
    public void Tick() => _currentState?.Tick();
}
