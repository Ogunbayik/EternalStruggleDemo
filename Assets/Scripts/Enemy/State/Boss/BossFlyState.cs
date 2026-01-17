using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BossFlyState : IEnemyState
{
    private EnemyBrain _brain;
    private EnemyBase _enemy;

    public BossFlyState(EnemyBase enemy) => _enemy = enemy;
    public void Initialize(EnemyBrain brain) => _brain = brain;

    private float _offsetY = 5f;
    private float _moveTimer = 2f;

    public void EnterState()
    {
        Debug.Log("Boss is Flying!");
        HandleFlySequence();
    }

    public void ExitState()
    {

    }

    public void Tick()
    {

    }
    private void HandleFlySequence()
    {
        Sequence flySequence = DOTween.Sequence();
        flySequence.AppendCallback(() => _enemy.transform.DOMoveY(_offsetY, _moveTimer).SetEase(Ease.InOutQuad));
        flySequence.AppendInterval(_moveTimer);
        flySequence.AppendCallback(() => _brain.SwitchState<EnemyAttackState>());
    }

}
