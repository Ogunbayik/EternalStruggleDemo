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
    private float _flyTime = 2f;
    private float _landTime = 2.5f;

    public void EnterState()
    {
        Debug.Log("Boss is Flying!");

        if (!_enemy.IsFlying)
            HandleFlySequence();
        else
            HandleLandSequce();
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
        flySequence.AppendCallback(() => _enemy.transform.DOMoveY(_offsetY, _flyTime).SetEase(Ease.InOutQuad));
        flySequence.AppendInterval(_flyTime);
        flySequence.AppendCallback(() => _brain.SwitchState<EnemyAttackState>());
    }

    private void HandleLandSequce()
    {
        Sequence landSequence = DOTween.Sequence();
        landSequence.AppendCallback(() => _enemy.transform.DOMoveY(-_offsetY, _landTime).SetEase(Ease.OutCirc));
        landSequence.AppendInterval(_landTime);
        landSequence.AppendCallback(() => _brain.SwitchState<BossDecideState>());
    }

}
