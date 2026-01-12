using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardKeyboard : IInputService
{
    public float GetHorizontal() => Input.GetAxis(Const.PlayerInput.HORIZONTAL_INPUT);
    public float GetVertical() => Input.GetAxis(Const.PlayerInput.VERTICAL_INPUT);

}
