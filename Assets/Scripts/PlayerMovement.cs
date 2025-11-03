using br.com.Fonazo;
using br.com.Fonazo.Managers;
using UnityEngine;
using UnityEngine.InputSystem;

namespace br.com.Fonazo.Movement
{
    public class PlayerMovement : CharacterMovement
    {
        private Vector2 moveVectorInput;

        private void Update()
        {
            Rb.MovePosition(Rb.position + MoveVector * (moveSpeed * Time.deltaTime));
        }
        

        public void OnMove(InputAction.CallbackContext context)
        {
            moveVectorInput = context.ReadValue<Vector2>();
            HorizontalMove(moveVectorInput.x);
        }
    }
}