using br.com.Fonazo;
using br.com.Fonazo.Managers;
using UnityEngine;
using UnityEngine.InputSystem;

namespace br.com.Fonazo.Movement
{
    public class PlayerMovement : CharacterMovement
    {
        private Vector2 moveInput;


        public void OnMove(InputAction.CallbackContext context)
        {
            moveInput = context.ReadValue<Vector2>();
            Move2D(moveInput.x);
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