using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerView 
{
    public event Action<float, float> OnMovementInput;
    void HandleMovement(Vector3 direction);
}
