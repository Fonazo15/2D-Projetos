using br.com.Fonazo;
using UnityEngine;

namespace br.com.Fonazo.Movement
{
    public class CharacterMovement : MonoBehaviour
    {
        public float moveSpeed = 3f;
        internal bool IsGrounded;
        internal Vector2 MoveVector;
        internal Rigidbody2D Rb;

        private void Awake()
        {
            Rb = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            moveSpeed = GameManager.Instance.Convert(moveSpeed);
        }

        private void FixedUpdate()
        {
            ApplyGravity();
        }

        internal void HorizontalMove(float movementX)
        {
            MoveVector.x = movementX;
        }

        internal void ApplyGravity()
        {
            if (IsGrounded)
            {
                Rb.linearVelocityY = -0.2f;
            }
            else
            {
                Rb.linearVelocityY = -9.81f;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            
        }
    }

    public struct Checkpoint2D
    {
        private Vector2 position;
        private Vector2 target;

        public Checkpoint2D(Vector2 position, Vector2 target)
        {
            this.position = position;
            this.target = target;
        }

        public bool Arrived()
        {
            return Vector2.Distance(target, position) <= 0.1f;
        }
    }
}