using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float jumpForce = 20f;
    private Vector2 _moveAction;
    private Rigidbody2D _rb;
    private bool _isGrounded = true;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        _rb.linearVelocity = new Vector2(_moveAction.x * moveSpeed * Time.deltaTime, _rb.linearVelocity.y);
    }
    internal void HorizontalMovement(float moveX)
    {
        _moveAction.x = moveX;
    }

    internal void Jump()
    {
        if (_isGrounded)
        {
            _isGrounded = false;
            _rb.AddForce(jumpForce * Vector2.up, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _isGrounded = collision.collider.CompareTag("Ground");
    }
}
