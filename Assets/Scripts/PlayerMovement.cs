using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : CharacterMovement
{
    private Vector2 _moveInput;

    public void OnHorizontalMove(InputAction.CallbackContext context)
    {
        _moveInput = context.ReadValue<Vector2>();
        HorizontalMovement(_moveInput.x);
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed)
            Jump();
    }
}
