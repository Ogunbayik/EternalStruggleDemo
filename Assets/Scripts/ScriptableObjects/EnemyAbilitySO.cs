using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyAbilitySO : ScriptableObject, IAbility
{
    protected EnemyBase _enemy;

    [SerializeField] protected string _abilityName;
    [SerializeField] protected float _cooldown;

    public abstract void ExecuteAbility(EnemyBase enemy, Transform target);
    public abstract void OnEffectRealized(EnemyBase enemy, Transform target);

}
