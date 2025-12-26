using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemyBase : MonoBehaviour
{
    protected EnemyDataSO _enemyData;
    protected IAbility _ability;

    [Inject]
    public void Construct(EnemyDataSO data, IAbility ability)
    {
        _enemyData = data;
        _ability = ability;
    }
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
