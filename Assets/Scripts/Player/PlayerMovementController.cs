using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using Zenject;

public class PlayerMovementController : MonoBehaviour
{
    private CharacterController _characterController;

    private IInputService _inputService;
    private PlayerDataSO _playerDataSO;

    [Inject]
    public void Construct(IInputService inputService, PlayerDataSO data)
    {
        _inputService = inputService;
        _playerDataSO = data;
    }

    private Vector3 _movementDirection;
    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        HandleMovement();
    }
    private void HandleMovement()
    {
        var moveX = _inputService.HorizontalInput();
        var moveZ = _inputService.VerticalInput();

        _movementDirection.Set(moveX, 0f, moveZ);
        _characterController.SimpleMove(_movementDirection * _playerDataSO.MovementSpeed);
    }
}
