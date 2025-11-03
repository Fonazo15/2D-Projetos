using System.Collections.Generic;
using br.com.Fonazo;
using br.com.Fonazo.Editor.ScriptUtil;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

namespace br.com.Fonazo.Movement
{
    public class CharacterMovement : MonoBehaviour
    {
        public float moveSpeed = 3f;
        public MovementDictionary dictionary;
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

    [System.Serializable]
    public class MovementDictionary
    {
        
        public CustomDictionary<string, TagHandle> serialized_collisionDictionary = new CustomDictionary<string, TagHandle>();
        Dictionary<string, TagHandle> collisionDictionary = new Dictionary<string, TagHandle>();
        
    }
}