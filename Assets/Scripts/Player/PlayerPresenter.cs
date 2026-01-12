using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerPresenter : IInitializable, IDisposable
{
    private PlayerModel _model;
    private IPlayerView _view;


    public PlayerPresenter(PlayerModel model, IPlayerView view)
    {
        _model = model;
        _view = view;
    }

    public void Initialize()
    {
        _view.OnMovementInput += View_OnMovementInput;
    }
    public void Dispose()
    {
        _view.OnMovementInput -= View_OnMovementInput;
    }
    private void View_OnMovementInput(float horizontal, float vertical)
    {
        var movementDirection = new Vector3(horizontal, 0f, vertical);
        Vector3 motion = movementDirection * _model.Data.MovementSpeed;

        _view.HandleMovement(motion);
    }
}
