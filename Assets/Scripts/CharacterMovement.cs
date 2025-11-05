using br.com.Fonazo;
using UnityEngine;

namespace br.com.Fonazo.Movement
{
    public abstract class CharacterMovement : MonoBehaviour
    {
        [SerializeField] internal float moveSpeed = 3f;
        [SerializeField] internal float jumpForce = 5f;
        internal bool isGrounded = true;
        private Vector2 moveVector = Vector2.zero;
        internal Rigidbody2D rb;

        internal virtual void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        internal virtual void Start()
        {
            //moveSpeed = GameManager.Instance.Convert(moveSpeed);
            FreezeRotation();
        }

        internal void MoveX(Vector2 movementInput)
        {
            moveVector.x = movementInput.x;
        }

        internal void HandleMovement()
        {
            rb.linearVelocityX = moveVector.x * moveSpeed;
        }

        private void FreezeRotation()
        {
            rb.freezeRotation = true;
        }

        internal void Jump()
        {
            if (!isGrounded) return;
            isGrounded = false;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        

        internal virtual void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGrounded = true;
            }
        }

        internal virtual void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Point"))
            {
                
            }
        }
    }
    [System.Serializable]
    public struct Checkpoint2D
    {
        public Vector2 position;
    }
}