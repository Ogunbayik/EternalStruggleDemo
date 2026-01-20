using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWaitingState : IEnemyState
{
    private EnemyBrain _brain;
    private EnemyBase _enemy;
    public BossWaitingState(EnemyBase enemy) => _enemy = enemy;
    public void Initialize(EnemyBrain brain) => _brain = brain;

    public void EnterState()
    {
        Debug.Log("Boss is waiting that Player kill all enemies!");

        _brain.SwitchState<BossFlyState>();
    }
    public void ExitState()
    {

    }
    public void Tick()
    {

    }
}
