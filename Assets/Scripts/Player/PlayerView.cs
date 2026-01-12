using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

[RequireComponent(typeof(CharacterController))]
public class PlayerView : MonoBehaviour, IPlayerView
{
    private IInputService _keyboardInput;
    private CharacterController _characterController;

    [Inject]
    public void Construct(IInputService keyboardInput)
    {
        _keyboardInput = keyboardInput;
    }

    public event Action<float, float> OnMovementInput;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        var horizontalInput = _keyboardInput.GetHorizontal();
        var verticalInput = _keyboardInput.GetVertical();

        OnMovementInput?.Invoke(horizontalInput, verticalInput);
    }
    public void HandleMovement(Vector3 direction) => _characterController.SimpleMove(direction);
}
