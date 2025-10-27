using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    private Vector2 _movement;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        _rb.MovePosition(_movement * moveSpeed * Time.deltaTime);
    }
    public void Move(Vector2 _moveTo)
    {
        _movement = _moveTo;
    }
}
