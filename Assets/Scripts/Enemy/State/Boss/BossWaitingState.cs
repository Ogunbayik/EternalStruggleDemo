using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWaitingState : IEnemyState
{
    private EnemyBrain _brain;
    private BossBase _boss;
    public BossWaitingState(BossBase boss) => _boss = boss;
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
