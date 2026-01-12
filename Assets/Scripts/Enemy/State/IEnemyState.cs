using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyState
{
    void Initialize(EnemyBrain brain);

    void EnterState();
    void ExitState();
    void Tick();
}
