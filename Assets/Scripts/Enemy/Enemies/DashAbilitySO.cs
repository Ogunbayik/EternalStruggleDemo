using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Dash Ability")]
public class DashAbilitySO : EnemyAbilitySO
{
    public override void ExecuteAbility(EnemyBase enemy, Transform target)
    {
        Debug.Log("Execute dash ability and activate animation");
        
    }

    public override void OnEffectRealized(EnemyBase enemy, Transform target)
    {
        var desiredDirection = target.transform.position - new Vector3(0f, 0f, 2f);
        enemy.transform.position = desiredDirection;
    }
}
