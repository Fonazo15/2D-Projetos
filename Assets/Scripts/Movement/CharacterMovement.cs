using br.com.Fonazo;
using UnityEngine;

namespace br.com.Fonazo.Movement
{
    public abstract class CharacterMovement : MonoBehaviour
    {
        [SerializeField] internal float moveSpeed = 3f;
        [SerializeField] internal float jumpForce = 5f;
        internal bool isGrounded = true;
        internal Rigidbody2D rb;

        internal virtual void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            FreezeRotation();
        }

        internal void Move2D(float direction)
        {
            rb.linearVelocityX = direction * moveSpeed;
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
        

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGrounded = true;
            }
        }
    }
    [System.Serializable]
    public struct Checkpoint2D
    {
        public Vector2 position;
        public static Checkpoint2D GetStartPoint(Checkpoint2D[] checkpoints)
        {
            return checkpoints[0];
        }
        public static Checkpoint2D GetEndPoint(Checkpoint2D[] checkpoints)
        {
            return checkpoints[^1];
        }
    }
}