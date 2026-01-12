using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemyBase : MonoBehaviour
{
    private EnemyDataSO _data;

    [Inject]
    public void Construct(EnemyDataSO data)
    {
        _data = data;
    }
    public void ChaseTarget(Transform target) => transform.position = Vector3.MoveTowards(transform.position, target.position, _data.MovementSpeed * Time.deltaTime);
    public EnemyDataSO Data => _data;
}
