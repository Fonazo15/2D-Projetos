using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    private Vector2 _moveInput;
    public virtual void OnMove(InputAction.CallbackContext ctx)
    {
        _moveInput = ctx.ReadValue<Vector2>();
    }

    private void Update()
    {
        transform.Translate(_moveInput * (moveSpeed * Time.deltaTime));
    }
}
