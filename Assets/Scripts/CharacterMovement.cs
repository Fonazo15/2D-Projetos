using br.com.Fonazo;
using br.com.Fonazo.Managers;
using UnityEngine;

namespace br.com.Fonazo
{
    namespace Movement
    {
        public class CharacterMovement : MonoBehaviour
        {
            public float speed = 3f;
            internal Vector2 movementInput;
            internal Rigidbody2D rb;

            private void Awake()
            {
                rb = GetComponent<Rigidbody2D>();
            }

            private void Start()
            {
                speed = GameManager.Instance.Convert(speed);
            }

            public void Move(Vector2 moveTo)
            {
                movementInput = moveTo;
            }
        }

        public struct Checkpoint
        {
            private Vector2 position;
            private Vector2 target;

            public Checkpoint(Vector2 position, Vector2 target)
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
}