using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : CharacterMovement
{
    private Vector2 _moveInput;

    public void OnMove(InputAction.CallbackContext context)
    {
        _moveInput = context.ReadValue<Vector2>();
        Move(_moveInput);
    }
}
