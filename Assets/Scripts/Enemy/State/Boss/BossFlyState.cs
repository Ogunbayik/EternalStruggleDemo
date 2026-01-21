using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BossFlyState : IEnemyState
{
    private EnemyBrain _brain;
    private BossBase _boss;

    public BossFlyState(BossBase boss) => _boss = boss;
    public void Initialize(EnemyBrain brain) => _brain = brain;

    private float _offsetYFly = 5f;
    private float _flyTime = 2f;

    public void EnterState()
    {
        _boss.SetAttackStrategy(_boss.GetRandomRangeStrategy());
        _boss.SetFlyingStatus(true);
        HandleFlySequence();
        Debug.Log("Boss is Flying!");
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
        flySequence.AppendCallback(() => _boss.transform.DOMoveY(_offsetYFly, _flyTime).SetEase(Ease.InOutQuad));
        flySequence.AppendInterval(_flyTime);
        flySequence.AppendCallback(() => _brain.SwitchState<EnemyAttackState>());
    }
}
