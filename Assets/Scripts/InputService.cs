using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputService : IInputService
{
    public float HorizontalInput() => Input.GetAxis(GameConstants.PlayerInputs.HORIZONTAL_INPUT);

    public float VerticalInput() => Input.GetAxis(GameConstants.PlayerInputs.VERTICAL_INPUT);
    
}
