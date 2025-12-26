
using UnityEngine;

public interface IAbility 
{
    void ExecuteAbility(EnemyBase enemy, Transform target);
    void OnEffectRealized(EnemyBase enemy, Transform target);
}
