using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChaseState : IEnemyState
{
    private readonly EnemyStateMachine _stateMachine;

    public EnemyChaseState(EnemyStateMachine stateMachine)
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

    }
}
