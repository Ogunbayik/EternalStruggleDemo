using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDecideState : IEnemyState
{
    private EnemyBrain _brain;
    private EnemyBase _enemybase;

    public BossDecideState(EnemyBase enemyBase) => _enemybase = enemyBase;
    public void Initialize(EnemyBrain brain) => _brain = brain;
    public void EnterState()
    {
        Debug.Log("Boss is deciding a attack");
    }

    public void ExitState()
    {

    }

    public void Tick()
    {
        
    }

    private void DecideNextMove()
    {
        if(_enemybase.IsFlying)
        {
            //Range Attack Again
            //Landing
            if(_enemybase is BossBase bossBase)
            {
                bossBase.CanAttackAgain(5);
            }
        }
    }
}
