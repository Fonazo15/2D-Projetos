using br.com.Fonazo;
using br.com.Fonazo.Managers;
using UnityEngine;
using UnityEngine.InputSystem;

namespace br.com.Fonazo
{
    namespace Movement
    {
        public class PlayerMovement : CharacterMovement
        {
            private float moveSpeed;

            private void Start()
            {
                moveSpeed = GameManager.Instance.Convert(moveSpeed);
            }

            private void Update()
            {
                rb.MovePosition(rb.position + movementInput * (moveSpeed * Time.deltaTime));
            }

            public void OnMove(InputAction.CallbackContext context)
            {
                movementInput = context.ReadValue<Vector2>();
                Move(movementInput);
            }
        }
    }
}