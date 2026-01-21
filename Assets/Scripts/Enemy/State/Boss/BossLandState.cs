using DG.Tweening;

public class BossLandState : IEnemyState
{
    private EnemyBrain _brain;
    private BossBase _boss;

    private float _groundY = 0f;
    private float _landTime = 3f;

    public BossLandState(BossBase boss) => _boss = boss;
    public void Initialize(EnemyBrain brain) => _brain = brain;

    public void EnterState()
    {
        HandleLandSequence();
    }

    public void ExitState()
    {

    }

    public void Tick()
    {

    }
    private void HandleLandSequence()
    {
        Sequence landSequence = DOTween.Sequence();
        landSequence.AppendCallback(() => _boss.transform.DOMoveY(_groundY, _landTime).SetEase(Ease.OutCubic));
        landSequence.AppendInterval(_landTime);
        landSequence.AppendCallback(() => _brain.SwitchState<BossDecideState>());
        landSequence.JoinCallback(() => _boss.SetFlyingStatus(false));
    }
}
