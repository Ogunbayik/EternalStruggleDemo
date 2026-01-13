using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : IAttackStrategy
{
    public void ExecuteAttack()
    {
        Debug.Log("Swinging the sword");
    }
}
