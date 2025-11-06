using br.com.Fonazo;
using br.com.Fonazo.Managers;
using UnityEngine;
using UnityEngine.InputSystem;

namespace br.com.Fonazo.Movement
{
    public class PlayerMovement : CharacterMovement
    {
        private Vector2 moveInput;

        private void FixedUpdate()
        {
            HandleMovement();
        }
        

        public void OnMove(InputAction.CallbackContext context)
        {
            moveInput = context.ReadValue<Vector2>();
            MoveX(moveInput);
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                Jump();
            }
        }
    }
}