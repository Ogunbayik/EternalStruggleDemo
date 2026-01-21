using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDecideState : IEnemyState
{
    private EnemyBrain _brain;
    private BossBase _boss;

    public BossDecideState(BossBase boss) => _boss = boss;  
    public void Initialize(EnemyBrain brain) => _brain = brain;

    private float _decideTimer;
   
    public void EnterState()
    {
        if (_boss.IsFlying && _boss.FlyAttackCount >= 3)
        {
            _boss.ResetFlyAttackCount();
            _brain.SwitchState<BossLandState>();
            return;
        }

        Debug.Log("Boss is deciding a attack");
        _decideTimer = GetRandomDecideTime();
    }

    public void ExitState()
    {
        
    }

    public void Tick()
    {
        _decideTimer -= Time.deltaTime;


        if(_decideTimer <= 0)
        {
            _decideTimer = 0;

            if(_boss.IsFlying)
            {
                _boss.SetAttackStrategy(_boss.GetRandomRangeStrategy());
                _brain.SwitchState<EnemyAttackState>();
            }
            else
            {
                _brain.SwitchState<BossFlyState>();
            }
        }

        
    }
    private float GetRandomDecideTime()
    {
        if (_boss.Data is BossDataSO bossData)
        {
            var randomTime = UnityEngine.Random.Range(bossData.MinimumDecideTime, bossData.MaximumDecideTime);
            return randomTime;
        }
        else
            throw new System.InvalidOperationException("Boss data is missing or is not of type BossDataSO.");
    }
}
