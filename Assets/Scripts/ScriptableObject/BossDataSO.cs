using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Data", menuName = "SO/Enemy/Boss Data")]
public class BossDataSO : EnemyDataSO
{
    [Header("Decide Settings")]
    [SerializeField] private float _minimumDecideTime;
    [SerializeField] private float _maximumDecideTime;


    public float MinimumDecideTime => _minimumDecideTime;
    public float MaximumDecideTime => _maximumDecideTime;
}
